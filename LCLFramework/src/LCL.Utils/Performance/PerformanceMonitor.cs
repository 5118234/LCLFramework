﻿
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace LCL
{
    /// <summary>
    /// Socket 性能监视器
    /// http://www.cnblogs.com/xh831213/archive/2008/06/12/1218234.html
    /// </summary>
    public class PerformanceMonitor : IDisposable
    {
        private Timer m_PerformanceTimer;
        private int m_TimerInterval;//获取性能数据收集时间间隔,以秒为单位。

        private PerformanceCounter m_CpuUsagePC;
        private PerformanceCounter m_ThreadCountPC;
        private PerformanceCounter m_WorkingSetPC;

        private int m_CpuCores = 1;

        private Dictionary<Type, List<KeyValuePair<PropertyInfo, DisplayAttribute>>> m_SummaryMetadataDict = new Dictionary<Type, List<KeyValuePair<PropertyInfo, DisplayAttribute>>>();

        private static readonly object[] m_ParaArray = new object[0];

        public PerformanceMonitor()
        {
            Process process = Process.GetCurrentProcess();

            m_CpuCores = Environment.ProcessorCount;

            var isUnix = Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX;
            var instanceName = (isUnix) ? string.Format("{0}/{1}", process.Id, process.ProcessName) : GetPerformanceCounterInstanceName(process);

            SetupPerformanceCounters(instanceName);

            m_TimerInterval = 30 * 1000;
            m_PerformanceTimer = new Timer(OnPerformanceTimerCallback);
        }

        private void SetupPerformanceCounters(string instanceName)
        {
            m_CpuUsagePC = new PerformanceCounter("Process", "% Processor Time", instanceName);
            m_ThreadCountPC = new PerformanceCounter("Process", "Thread Count", instanceName);
            m_WorkingSetPC = new PerformanceCounter("Process", "Working Set", instanceName);
        }

        private static string GetPerformanceCounterInstanceName(Process process)
        {
            var processId = process.Id;
            var processCategory = new PerformanceCounterCategory("Process");
            var runnedInstances = processCategory.GetInstanceNames();

            foreach (string runnedInstance in runnedInstances)
            {
                if (!runnedInstance.StartsWith(process.ProcessName, StringComparison.OrdinalIgnoreCase))
                    continue;

                using (var performanceCounter = new PerformanceCounter("Process", "ID Process", runnedInstance, true))
                {
                    if ((int)performanceCounter.RawValue == processId)
                    {
                        return runnedInstance;
                    }
                }
            }

            return process.ProcessName;
        }

        public void Start()
        {
            m_PerformanceTimer.Change(0, m_TimerInterval);
        }

        public void Stop()
        {
            m_PerformanceTimer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private List<KeyValuePair<PropertyInfo, DisplayAttribute>> GetSummaryTypeMetatdata(Type summaryType)
        {
            List<KeyValuePair<PropertyInfo, DisplayAttribute>> stateMetadata;

            if (m_SummaryMetadataDict.TryGetValue(summaryType, out stateMetadata))
                return stateMetadata;

            stateMetadata = new List<KeyValuePair<PropertyInfo, DisplayAttribute>>();

            foreach (var p in summaryType.GetProperties())
            {
                var att = p.GetCustomAttributes(false).FirstOrDefault() as DisplayAttribute;

                if (att != null && att.OutputInPerfLog)
                {
                    stateMetadata.Add(new KeyValuePair<PropertyInfo, DisplayAttribute>(p, att));
                }
            }

            m_SummaryMetadataDict.Add(summaryType, stateMetadata.OrderBy(s => s.Value.Order).ToList());
            return stateMetadata;
        }

        private void OnPerformanceTimerCallback(object state)
        {
            int availableWorkingThreads, availableCompletionPortThreads;
            ThreadPool.GetAvailableThreads(out availableWorkingThreads, out availableCompletionPortThreads);

            int maxWorkingThreads;
            int maxCompletionPortThreads;
            ThreadPool.GetMaxThreads(out maxWorkingThreads, out maxCompletionPortThreads);

            NodeSummary globalPerfData = null;

            var retry = false;

            while (true)
            {
                try
                {
                    globalPerfData = new NodeSummary
                    {
                        AvailableWorkingThreads = availableWorkingThreads,
                        AvailableCompletionPortThreads = availableCompletionPortThreads,
                        MaxCompletionPortThreads = maxCompletionPortThreads,
                        MaxWorkingThreads = maxWorkingThreads,
                        CpuUsage = m_CpuUsagePC.NextValue() / m_CpuCores,
                        TotalThreadCount = (int)m_ThreadCountPC.NextValue(),
                        WorkingSet = (long)m_WorkingSetPC.NextValue()
                    };

                    break;
                }
                catch (InvalidOperationException e)
                {
                    if (retry)
                        throw e;
                    if (Environment.OSVersion.Platform == PlatformID.Unix 
                        || Environment.OSVersion.Platform == PlatformID.MacOSX)
                        throw e;
                    var newInstanceName = GetPerformanceCounterInstanceName(Process.GetCurrentProcess());
                    SetupPerformanceCounters(newInstanceName);
                    retry = true;
                }
            }

            var perfBuilder = new StringBuilder();

            perfBuilder.AppendLine("---------------------------------------------------");
            perfBuilder.AppendLine(string.Format("CPU Usage: {0}%, Physical Memory Usage: {1:N}, Total Thread Count: {2}", globalPerfData.CpuUsage.ToString("0.00"), globalPerfData.WorkingSet, globalPerfData.TotalThreadCount));
            perfBuilder.AppendLine(string.Format("AvailableWorkingThreads: {0}, AvailableCompletionPortThreads: {1}", globalPerfData.AvailableWorkingThreads, globalPerfData.AvailableCompletionPortThreads));
            perfBuilder.AppendLine(string.Format("MaxWorkingThreads: {0}, MaxCompletionPortThreads: {1}", globalPerfData.MaxWorkingThreads, globalPerfData.MaxCompletionPortThreads));

            Logger.LogDebug("Performance:" + perfBuilder.ToString());
        }

        public void Dispose()
        {
            if (m_PerformanceTimer != null)
            {
                m_PerformanceTimer.Dispose();
                m_PerformanceTimer = null;
            }

            if (m_CpuUsagePC != null)
            {
                m_CpuUsagePC.Close();
                m_CpuUsagePC = null;
            }

            if (m_ThreadCountPC != null)
            {
                m_ThreadCountPC.Close();
                m_ThreadCountPC = null;
            }

            if (m_WorkingSetPC != null)
            {
                m_WorkingSetPC.Close();
                m_WorkingSetPC = null;
            }
        }
    }
    /// <summary>
    /// Display attribute
    /// </summary>
    public class DisplayAttribute : Attribute
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>
        /// The short name.
        /// </value>
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        /// <value>
        /// The format.
        /// </value>
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        public int Order { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether [output in perf log].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [output in perf log]; otherwise, <c>false</c>.
        /// </value>
        public bool OutputInPerfLog { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayAttribute" /> class.
        /// </summary>
        public DisplayAttribute()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public DisplayAttribute(string name)
        {
            Name = name;
            OutputInPerfLog = true;
        }
    }
}

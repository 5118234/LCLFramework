/*******************************************************  
*   
* ���ߣ�������  
* ˵����  
* ���л�����.NET 4.5.0  
* �汾�ţ�1.0.0  
*   
* ��ʷ��¼��  
*    �����ļ� ������ 20154��18�� ������ 
*   
*******************************************************/
using LCL;
using LCL.Repositories;
using LCL.Repositories.EntityFramework;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Web;

namespace UIShell.RbacPermissionService
{
    public interface IScheduledEventsRepository : IRepository<ScheduledEvents>
    {
        List<ScheduledEvents> GetAll();
        Result AjaxExecCommand(string Key, HttpContextBase context);
        Result Delete(string Key);
    }
    public class ScheduledEventsRepository : EntityFrameworkRepository<ScheduledEvents>, IScheduledEventsRepository
    {
        public ScheduledEventsRepository(IRepositoryContext context)
            : base(context)
        {

        }
        public List<ScheduledEvents> GetAll()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("key", typeof(string));
            dt.Columns.Add("scheduletype", typeof(string));
            dt.Columns.Add("exetime", typeof(string));
            dt.Columns.Add("lastexecuted", typeof(DateTime));
            dt.Columns.Add("issystemevent", typeof(bool));
            dt.Columns.Add("enable", typeof(bool));
            EventInfo[] events = ScheduleConfigs.GetConfig().Events;
            foreach (EventInfo ev in events)
            {
                DataRow dr = dt.NewRow();
                dr["key"] = ev.Key;
                dr["scheduletype"] = ev.ScheduleType;
                if (ev.TimeOfDay != -1)
                {
                    dr["exetime"] = "��ʱִ��:" + (ev.TimeOfDay / 60) + "ʱ" + (ev.TimeOfDay % 60) + "��";
                }
                else
                {
                    dr["exetime"] = "����ִ��:" + ev.Minutes + "����";
                }
                DateTime lastExecute = Event.GetLastExecuteScheduledEventDateTime(ev.Key, Environment.MachineName);
                if (lastExecute == DateTime.MinValue)
                {
                    dr["lastexecuted"] = Convert.ToDateTime("1999-01-01").ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    dr["lastexecuted"] = lastExecute.ToString("yyyy-MM-dd HH:mm:ss");
                }
                dr["issystemevent"] = ev.IsSystemEvent.ToString();// ? "ϵͳ��" : "��ϵͳ��";
                dr["enable"] = ev.Enabled.ToString();// ? "����" : "����";
                dt.Rows.Add(dr);
            }
            var list = dt.ToArray<ScheduledEvents>();
            return list.ToList();
        }
        public Result AjaxExecCommand(string Key, HttpContextBase context)
        {
            var result = new Result(true);
            try
            {
                if (!string.IsNullOrWhiteSpace(Key))
                {
                    EventInfo[] events = ScheduleConfigs.GetConfig().Events;
                    foreach (EventInfo ev in events)
                    {
                        if (ev.Key == Key)
                        {
                            ((IEvent)Activator.CreateInstance(Type.GetType(ev.ScheduleType))).Execute(context);
                            Event.SetLastExecuteScheduledEventDateTime(ev.Key, Environment.MachineName, DateTime.Now);
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                result = new Result(false);
            }
            return result;
        }


        public Result Delete(string Key)
        {
            ScheduleConfigInfo sci = ScheduleConfigs.GetConfig();
            sci.Events = sci.Events.Where(p => p.Key != Key).ToArray();
            ScheduleConfigs.SaveConfig(sci);
            return new Result(true);
        }
    }
}


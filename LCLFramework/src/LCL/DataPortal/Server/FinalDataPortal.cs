using LCL.DomainServices;
using LCL.Reflection;
using System;

namespace LCL.DataPortal.Server
{  
    /// <summary>
    /// ���յ���ʵ��� IDataPortalServer �Ż�ʵ�֡�
    /// </summary>
    public class FinalDataPortal : IDataPortalServer
    {
        /// <summary>
        /// �ǲֿ�����ʹ�� Fetch ʱ�Ļص���������
        /// </summary>
        private const string FetchMethod = "QueryBy";
        /// <summary>
        /// �ǲֿ�����ʹ�� Update ʱ�Ļص���������
        /// </summary>
        private const string UpdateMethod = "DataPortal_Update";
        /// <summary>
        /// ����ĳ�����͵Ĳ�ѯ�����Է�����������
        /// Fetches the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="criteria">The criteria.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public DataPortalResult Fetch(Type objectType, object criteria, DataPortalContext context)
        {
            var obj = Activator.CreateInstance(objectType, true);
            var res = MethodCaller.CallMethodIfImplemented(obj, FetchMethod, criteria);
            if (res != null)
                return new DataPortalResult(res);
            else
                return new DataPortalResult(obj);
        }
        public DataPortalResult Update(object obj, DataPortalContext context)
        {
            var target = obj as AggregateRoot;
            if (target != null)
            {
                target.SaveRoot();
            }
            else if (obj is DomainService)
            {
                (obj as DomainService).ExecuteByDataPortal();
            }
            else
            {
                MethodCaller.CallMethodIfImplemented(obj, UpdateMethod);
            }
            return new DataPortalResult(obj);
        }
        public DataPortalResult Action(Type objectType, string methodName, object criteria, DataPortalContext context)
        {
            var obj = Activator.CreateInstance(objectType, true);
            var res = MethodCaller.CallMethodIfImplemented(obj, methodName, criteria);
            if (res != null)
                return new DataPortalResult(res);
            else
                return new DataPortalResult(obj);
        }
    }
}
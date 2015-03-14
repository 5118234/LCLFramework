using LCL.DataPortal.DataPortalClient;
using System;
using System.Security.Principal;

namespace LCL.DataPortal
{
    /// <summary>
    /// �����Ż���
    /// �ڲ���װ�˶����ݲ�ĵ��ã������Զ�̣���ʹ�ö�Ӧ�Ĵ��������ʣ���ʹ�õ����桢�����ĵ�����ȫһ�¡�
    /// 1��ҵ�����Լ�� ����Ҫ�� QueryBy DataPortal_Update ������������
    /// </summary>
    public static class DataPortalApi
    {
        public static object Action(Type objectType, string methodName, object criteria, DataPortalLocation loc = DataPortalLocation.Dynamic)
        {
            var proxy = GetDataPortalProxy(loc);

            var dpContext = new Server.DataPortalContext(GetPrincipal(), proxy.IsServerRemote);

            Server.DataPortalResult result = null;

            try
            {
                result = proxy.Action(objectType, methodName, criteria, dpContext);
            }
            finally
            {
                if (proxy.IsServerRemote && result != null) { DistributionContext.SetGlobalContext(result.GlobalContext); }
            }
            //���ܵ��� ReturnObject=null
            return result.ReturnObject;
        }
        public static object Fetch(Type objectType, object criteria, DataPortalLocation loc = DataPortalLocation.Dynamic)
        {
            var proxy = GetDataPortalProxy(loc);

            var dpContext = new Server.DataPortalContext(GetPrincipal(), proxy.IsServerRemote);

            Server.DataPortalResult result = null;

            try
            {
                result = proxy.Fetch(objectType, criteria, dpContext);
            }
            finally
            {
                if (proxy.IsServerRemote && result != null) { DistributionContext.SetGlobalContext(result.GlobalContext); }
            }
            //���ܵ��� ReturnObject=null
            return result.ReturnObject;
        }
        public static object Update(object obj, DataPortalLocation loc = DataPortalLocation.Dynamic)
        {
            var proxy = GetDataPortalProxy(loc);

            var dpContext = new Server.DataPortalContext(GetPrincipal(), proxy.IsServerRemote);

            var result = proxy.Update(obj, dpContext);

            if (proxy.IsServerRemote) DistributionContext.SetGlobalContext(result.GlobalContext);

            return result.ReturnObject;
        }

        #region Helpers
        private static Type _proxyType;
        private static IDataPortalProxy GetDataPortalProxy(DataPortalLocation loc)
        {
            if (loc == DataPortalLocation.Local) return new LocalProxy();

            if (_proxyType == null)
            {
                string proxyTypeName = DistributionContext.DataPortalProxy;
                if (proxyTypeName == "Local") return new LocalProxy();

                _proxyType = Type.GetType(proxyTypeName, true, true);
            }
            return Activator.CreateInstance(_proxyType) as IDataPortalProxy;
        }
        private static IPrincipal GetPrincipal()
        {
            if (DistributionContext.User == null)
                DistributionContext.User = LEnvironment.Principal;

            return LEnvironment.Principal;

            //if (DistributionContext.AuthenticationType == "Windows")
            //{
            //    // Windows integrated security
            //    return null;
            //}
            //else
            //{
            //    // we assume using the CSLA framework security
            //    return DistributionContext.User;
            //}
        }
        #endregion
    }
}

using LCL.DataPortal.Server;
namespace LCL.DataPortal.DataPortalClient
{
    /// <summary>
    /// �ͻ��˵Ĵ���
    /// ��ͬ���� IDataPortalServer �����з�����
    /// </summary>
    public interface IDataPortalProxy :IDataPortalServer
    {
        /// <summary>
        /// Get a value indicating whether this proxy will invoke
        /// a remote data portal server, or run the "server-side"
        /// data portal in the caller's process and AppDomain.
        /// </summary>
        bool IsServerRemote { get; }
    }
}

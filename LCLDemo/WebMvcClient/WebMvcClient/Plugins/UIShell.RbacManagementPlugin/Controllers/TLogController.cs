/******************************************************* 
*  
* ���ߣ������� 
* ˵���� ϵͳ������־
* ���л�����.NET 4.5.0 
* �汾�ţ�1.0.0 
*  
* ��ʷ��¼�� 
*    �����ļ� ������ 20154��18�� ������
*  
*******************************************************/
using System.Linq;
using LCL.MvcExtensions;
using LCL.Repositories;
using System.Web.Mvc;
using UIShell.RbacPermissionService;
using LCL;

namespace UIShell.RbacManagementPlugin.Controllers
{
    public class TLogController : RbacController<TLog>
    {
        public TLogController()
        {
            repo = RF.Concrete<ITLogRepository>();
        }
       
    }
}


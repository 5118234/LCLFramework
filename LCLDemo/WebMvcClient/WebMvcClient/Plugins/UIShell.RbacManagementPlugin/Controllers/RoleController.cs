using LCL.Repositories;
using System.Web.Mvc;
/******************************************************* 
*  
* ���ߣ������� 
* ˵���� ��ɫ
* ���л�����.NET 4.5.0 
* �汾�ţ�1.0.0 
*  
* ��ʷ��¼�� 
*    �����ļ� ������ 20154��18�� ������
*  
*******************************************************/
using UIShell.RbacPermissionService;

namespace UIShell.RbacManagementPlugin.Controllers
{
    public class RoleController : RbacController<Role>
    {
        IRoleRepository repo = RF.Concrete<IRoleRepository>();
        public RoleController()
        {

        }

        public JsonResult CheckRoleName(string RoleName)
        {
            bool isValidate = repo.CheckRoleName(RoleName);
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}


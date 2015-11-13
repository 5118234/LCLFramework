using LCL.MetaModel;
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
using LCL.Repositories;
using System.Web.Mvc;
using UIShell.RbacPermissionService;

namespace UIShell.RbacManagementPlugin.Controllers
{
    public class RoleController : RbacController<Role>
    {
        IRoleRepository repo = RF.Concrete<IRoleRepository>();
        public RoleController()
        {
            // hasPermission = PermissionMgr.HasCommand(pluginName, controller, Name);
            //var model = CommonModel.Modules[typeof(RoleController)];
            //var number = model.CustomOpertions.Count;
        }
        public JsonResult CheckRoleName(string RoleName)
        {
            bool isValidate = repo.CheckRoleName(RoleName);
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}


/******************************************************* 
*  
* ���ߣ������� 
* ˵���� �û�
* ���л�����.NET 4.5.0 
* �汾�ţ�1.0.0 
*  
* ��ʷ��¼�� 
*    �����ļ� ������ 20154��18�� ������
*  
*******************************************************/
using LCL;
using LCL.MvcExtensions;
using LCL.Repositories;
using System.Collections.Generic;
using System.Web.Mvc;

using UIShell.RbacPermissionService;

namespace UIShell.RbacManagementPlugin.Controllers
{
    public class UserController : RbacController<User>
    {
        IUserRepository repo = RF.Concrete<IUserRepository>();
        public UserController()
        {
         
        }
        [Permission("��������", "ResetPassword")]
        [HttpPost]
        public CustomJsonResult ResetPassword(IList<string> idList)
        {
            var result = new Result(true);
            for (int i = 0; i < idList.Count; i++)
            {
                repo.ChangePassword(idList[i], "123456");
            }
            var json = new CustomJsonResult();
            json.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            json.Data = result;
            return json;
        }
    }
}


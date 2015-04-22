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
using LCL.MvcExtensions; 
using LCL.Repositories;
using LCL;
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Web; 
using System.Web.Mvc; 
using UIShell.RbacPermissionService; 
 
namespace UIShell.RbacManagementPlugin.Controllers 
{ 
    public class UserController : RbacController<User> 
    { 
        public UserController() 
        { 
       ddlUser(Guid.Empty); 

        } 
        public void ddlUser(Guid dtId) 
        { 
            var repo = RF.FindRepo<UnitInfo>(); 
            var list = repo.FindAll(); 
 
            List<SelectListItem> selitem = new List<SelectListItem>(); 
            if (list.Count() > 0) 
            { 
                var roots = list; 
                foreach (var item in roots) 
                { 
                    selitem.Add(new SelectListItem { Text = item.Name, Value = item.ID.ToString() }); 
                } 
            } 
            selitem.Insert(0, new SelectListItem { Text = "==UnitInfo_ID==", Value = "-1" }); 
            ViewData["ddlUser"] = selitem; 
        } 

 
    } 
} 


/******************************************************* 
*  
* ���ߣ������� 
* ˵���� ��ʦ��Ϣ���
* ���л�����.NET 4.5.0 
* �汾�ţ�1.0.0 
*  
* ��ʷ��¼�� 
*    �����ļ� ������ 20154��22�� ������
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
    public class User_TeacherCheckController : RbacController<User_TeacherCheck> 
    { 
        public User_TeacherCheckController() 
        { 
       //ddlUser_TeacherCheck(Guid.Empty); 

        } 
        public void ddlUser_TeacherCheck(Guid dtId) 
        { 
            var repo = RF.FindRepo<User_Teacher>(); 
            var list = repo.FindAll(); 
 
            List<SelectListItem> selitem = new List<SelectListItem>(); 
            if (list.Count() > 0) 
            { 
                var roots = list; 
                foreach (var item in roots) 
                { 
                    selitem.Add(new SelectListItem { Text = item.User.Name, Value = item.ID.ToString() }); 
                } 
            } 
            selitem.Insert(0, new SelectListItem { Text = "==��ʦ��Ϣ���==", Value = "-1" }); 
            ViewData["ddlUser_TeacherCheck"] = selitem; 
        } 

 
    } 
} 


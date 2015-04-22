/******************************************************* 
*  
* ���ߣ������� 
* ˵���� ��ʦ
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
    public class User_TeacherController : RbacController<User_Teacher>
    {
        public User_TeacherController()
        {
            //ddlUser_Teacher(Guid.Empty);
            //ddlUser_User(Guid.Empty);

        }
        public void ddlUser_Teacher(Guid dtId)
        {
            var repo = RF.FindRepo<SchoolInfo>();
            var list = repo.FindAll();

            List<SelectListItem> selitem = new List<SelectListItem>();
            if (list.Count() > 0)
            {
                var roots = list;
                foreach (var item in roots)
                {
                    selitem.Add(new SelectListItem { Text = item.UnitInfo.Name, Value = item.UnitInfo.ID.ToString() });
                }
            }
            selitem.Insert(0, new SelectListItem { Text = "==��ʦ==", Value = "-1" });
            ViewData["ddlUser_Teacher"] = selitem;
        }
        public void ddlUser_User(Guid dtId)
        {
            var repo = RF.FindRepo<User>();
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
            selitem.Insert(0, new SelectListItem { Text = "==ѧ��==", Value = "-1" });
            ViewData["ddlUser_Teacher"] = selitem;
        }


    }
}


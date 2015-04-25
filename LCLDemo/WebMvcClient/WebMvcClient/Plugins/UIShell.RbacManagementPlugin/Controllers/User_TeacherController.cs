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

        }
        public override System.Web.Mvc.ActionResult Index(int? currentPageNum, int? pageSize, System.Web.Mvc.FormCollection collection)
        {
            if (!currentPageNum.HasValue)
                currentPageNum = 1;
            if (!pageSize.HasValue)
                pageSize = PagedListViewModel<SchoolInfoPageListViewModel>.DefaultPageSize;

            string schoolId = LRequest.GetString("schoolId");

            var list = RF.Concrete<ISchoolInfoRepository>().GetSchoolTeacherList(Guid.Parse(schoolId));
            var contactLitViewModel = new PagedListViewModel<SchoolTeacherViewModel>(currentPageNum.Value, pageSize.Value, list);
            return View(contactLitViewModel);
        }


    }
}


/******************************************************* 
*  
* ���ߣ������� 
* ˵���� �ֵ����
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
    public class DictionaryController : RbacController<Dictionary>
    {
        IDictionaryRepository repo = RF.Concrete<IDictionaryRepository>();

        public DictionaryController()
        {
            ddlDictionary(Guid.Empty);
        }
        public void ddlDictionary(Guid dtId)
        {
            var repo = RF.FindRepo<DictType>();
            var list = repo.FindAll();

            List<SelectListItem> selitem = new List<SelectListItem>();
            if (list.Count() > 0)
            {
                var roots = list;
                foreach (var item in roots)
                {
                    selitem.Add(new SelectListItem { Text =item.DicDes+"("+ item.Name+")", Value = item.ID.ToString() });
                }
            }
            selitem.Insert(0, new SelectListItem { Text = "==�ֵ�����==", Value = "-1" });
            ViewData["ddlDictionary"] = selitem;
        }
        public override System.Web.Mvc.ActionResult Index(int? currentPageNum, int? pageSize, System.Web.Mvc.FormCollection collection)
        {
            if (!currentPageNum.HasValue)
            {
                currentPageNum = 1;
            }
            if (!pageSize.HasValue)
            {
                pageSize = PagedListViewModel<Dictionary>.DefaultPageSize;
            }
            int pageNum = currentPageNum.Value;

            Guid guid = Guid.Parse(LRequest.GetString("dicTypeId"));

            var list = repo.GetDictTypeList(guid);

            var contactLitViewModel = new PagedListViewModel<Dictionary>(pageNum, pageSize.Value, list.ToList());

            return View(contactLitViewModel);
        }
    }
}


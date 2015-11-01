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
        [Permission("��ҳ", "Index")]
        public override System.Web.Mvc.ActionResult Index(int? currentPageNum, int? pageSize, System.Web.Mvc.FormCollection collection)
        {
            if (!currentPageNum.HasValue)
            {
                currentPageNum = 1;
            }
            if (!pageSize.HasValue)
            {
                pageSize = PagedResult<TLog>.DefaultPageSize;
            }
            int pageNum = currentPageNum.Value;

            var list = repo.FindAll(p => p.UpdateDate, LCL.SortOrder.Descending);

            var contactLitViewModel = new PagedResult<TLog>(pageNum, pageSize.Value, list.ToList());

            return View(contactLitViewModel);
        }
        public override ActionResult Add(AddOrEditViewModel<TLog> model, FormCollection collection)
        {
            return base.Add(model, collection);
        }
        public override ActionResult Edit(AddOrEditViewModel<TLog> model, FormCollection collection)
        {
            return base.Edit(model, collection);
        }
        public override ActionResult Delete(TLog model, int? currentPageNum, int? pageSize, FormCollection collection)
        {
            return base.Delete(model, currentPageNum, pageSize, collection);
        }
    }
}


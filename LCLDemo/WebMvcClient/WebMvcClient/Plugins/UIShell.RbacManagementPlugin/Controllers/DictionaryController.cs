using LCL;
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
using LCL.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UIShell.RbacPermissionService;

namespace UIShell.RbacManagementPlugin.Controllers
{
    public class DictionaryController : RbacController<Dictionary>
    {
        IDictionaryRepository repo = RF.Concrete<IDictionaryRepository>();

        public DictionaryController()
        {

        }
        [HttpPost]
        public JsonResult GetDicChildList(Guid? dictId)
        {
            if (!dictId.HasValue)
            {
                dictId = Guid.Empty;
            }
            var spec = Specification<Dictionary>.Eval(p => p.DictType.ID == dictId);
            var list = repo.FindAll(spec).ToList();
            return Json(list.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}


/******************************************************* 
*  
* ���ߣ������� 
* ˵���� �ֵ�����
* ���л�����.NET 4.5.0 
* �汾�ţ�1.0.0 
*  
* ��ʷ��¼�� 
*    �����ļ� ������ 20154��18�� ������
*  
*******************************************************/
using LCL.MvcExtensions;
using System.Web.Mvc;
using System.Linq;
using UIShell.RbacPermissionService;
using System.Collections.Generic;
using System;

namespace UIShell.RbacManagementPlugin.Controllers
{
    public class DictTypeController : RbacController<DictType>
    {
        public DictTypeController()
        {

        }
        [Permission("ɾ��", "Delete")]
        [BizActivityLog("ɾ���ֵ�����", "Name")]
        public override ActionResult Delete(DictType village, int? currentPageNum, int? pageSize, FormCollection collection)
        {
            DbFactory.DBA.ExecuteText("DELETE Dictionary WHERE DictType_ID='" + village.ID + "'");
            return base.Delete(village, currentPageNum, pageSize, collection);
        }

        public List<EasyUITreeModel> easyTree = new List<EasyUITreeModel>();
        [HttpPost]
        public virtual CustomJsonResult AjaxEasyUITree()
        {
            var modelList = repo.FindAll().ToList();
            string id = LRequest.GetString("id");
            Guid guid = string.IsNullOrWhiteSpace(id) ? Guid.Empty : Guid.Parse(id);
            var list = modelList.Where(p => p.ParentId == guid);
            foreach (var item in list)
            {
                EasyUITreeModel model = new EasyUITreeModel();
                model.id = item.ID.ToString();
                model.attributes = item.ID.ToString();
                model.text = item.Code;
                model.parentId = item.ParentId.ToString();
                easyTree.Add(model);
            }
            var json = new CustomJsonResult();
            json.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            json.Data = easyTree;
            return json;
        }
    }
    public class EasyUITreeModel
    {
        public EasyUITreeModel()
        {
            state = "closed";
            Checked = false;
            children = null;
            iconCls = "icon-bullet_green";
        }
        public string id { get; set; }
        public string text { get; set; }
        public string state { get; set; }
        public string parentId { get; set; }
        public string iconCls { get; set; }
        public bool Checked { get; set; }
        public string attributes { get; set; }
        public List<EasyUITreeModel> children { get; set; }
    }
}


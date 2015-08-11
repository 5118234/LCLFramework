/******************************************************* 
*  
* 作者：罗敏贵 
* 说明： 字典类型
* 运行环境：.NET 4.5.0 
* 版本号：1.0.0 
*  
* 历史记录： 
*    创建文件 罗敏贵 20154月18日 星期六
*  
*******************************************************/
using LCL.MvcExtensions;
using System.Web.Mvc;
using UIShell.RbacPermissionService;

namespace UIShell.RbacManagementPlugin.Controllers
{
    public class DictTypeController : RbacController<DictType>
    {
        public DictTypeController()
        {

        }
        [Permission("删除", "Delete")]
        [BizActivityLog("删除字典类型", "Name")]
        public override ActionResult Delete(DictType village, int? currentPageNum, int? pageSize, FormCollection collection)
        {
            DbFactory.DBA.ExecuteText("DELETE Dictionary WHERE DictType_ID='" + village.ID + "'");
            return base.Delete(village, currentPageNum, pageSize, collection);
        }
    }
}


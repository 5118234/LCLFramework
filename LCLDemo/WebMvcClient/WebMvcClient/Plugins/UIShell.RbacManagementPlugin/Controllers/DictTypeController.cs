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
using UIShell.RbacPermissionService;

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
    }
}


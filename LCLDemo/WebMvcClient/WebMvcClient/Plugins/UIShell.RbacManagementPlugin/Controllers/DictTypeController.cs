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
    public class DictTypeController : RbacController<DictType>
    {
        public DictTypeController()
        {

        }
        public override ActionResult Delete(DictType village, int? currentPageNum, int? pageSize, FormCollection collection)
        {
            DbFactory.DBA.ExecuteText("DELETE dbo.Dictionary WHERE DictType_ID='" + village.ID + "'");
            return base.Delete(village, currentPageNum, pageSize, collection);
        }
    }
}


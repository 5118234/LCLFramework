/******************************************************* 
*  
* ���ߣ������� 
* ˵���� 
* ���л�����.NET 4.5.0 
* �汾�ţ�1.0.0 
*  
* ��ʷ��¼�� 
*    �����ļ� ������ 2015��11��28��
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
    public class WFRoutController : RbacController<WFRout> 
    { 
        public WFRoutController() 
        { 
        }
        [HttpPost]
        public override CustomJsonResult AjaxAdd(WFRout model)
        {
            return base.AjaxAdd(model);
        }
    } 
} 


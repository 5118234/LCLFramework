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
using LCL.Repositories;

namespace UIShell.RbacManagementPlugin.Controllers
{
    public class DictTypeController : RbacController<DictType>
    {
        IDictTypeRepository repo = RF.Concrete<IDictTypeRepository>();
        public DictTypeController()
        {
           
        }
      
    }
}


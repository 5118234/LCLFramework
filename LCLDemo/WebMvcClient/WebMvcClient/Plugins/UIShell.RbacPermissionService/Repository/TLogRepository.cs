/*******************************************************  
*   
* ���ߣ�������  
* ˵����  
* ���л�����.NET 4.5.0  
* �汾�ţ�1.0.0  
*   
* ��ʷ��¼��  
*    �����ļ� ������ 20154��18�� ������ 
*   
*******************************************************/  
using LCL.Repositories;  
using LCL.Repositories.EntityFramework;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace UIShell.RbacPermissionService  
{  
    public interface ITLogRepository : IRepository<TLog>  
    {  
  
    }  
    public class TLogRepository : EntityFrameworkRepository<TLog>, ITLogRepository  
    {  
        public TLogRepository(IRepositoryContext context)  
            : base(context)  
        {   
          
        }  
    }  
}  


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

namespace UIShell.RbacPermissionService  
{  
    public interface IScheduledEventsRepository : IRepository<ScheduledEvents>  
    {  
  
    }  
    public class ScheduledEventsRepository : EntityFrameworkRepository<ScheduledEvents>, IScheduledEventsRepository  
    {  
        public ScheduledEventsRepository(IRepositoryContext context)  
            : base(context)  
        {   
          
        }  
    }  
}  


/*******************************************************  
*   
* ���ߣ�������  
* ˵���� ��ҵԱ�� 
* ���л�����.NET 4.5.0  
* �汾�ţ�1.0.0  
*   
* ��ʷ��¼��  
*    �����ļ� ������ 20154��22�� ������ 
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
    public interface IUser_EmployeeRepository : IRepository<User_Employee>  
    {  
  
    }  
    public class User_EmployeeRepository : EntityFrameworkRepository<User_Employee>, IUser_EmployeeRepository  
    {  
        public User_EmployeeRepository(IRepositoryContext context)  
            : base(context)  
        {   
          
        }  
    }  
}  


/*******************************************************  
*   
* ���ߣ�������  
* ˵���� ѧ�� 
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
    public interface IUser_StudentRepository : IRepository<User_Student>  
    {  
  
    }  
    public class User_StudentRepository : EntityFrameworkRepository<User_Student>, IUser_StudentRepository  
    {  
        public User_StudentRepository(IRepositoryContext context)  
            : base(context)  
        {   
          
        }  
    }  
}  


/*******************************************************  
*   
* ���ߣ�������  
* ˵���� ��ʦ��Ϣ��� 
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
    public interface IUser_TeacherCheckRepository : IRepository<User_TeacherCheck>  
    {  
  
    }  
    public class User_TeacherCheckRepository : EntityFrameworkRepository<User_TeacherCheck>, IUser_TeacherCheckRepository  
    {  
        public User_TeacherCheckRepository(IRepositoryContext context)  
            : base(context)  
        {   
          
        }  
    }  
}  


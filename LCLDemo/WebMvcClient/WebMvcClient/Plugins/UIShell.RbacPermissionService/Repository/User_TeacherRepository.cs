/*******************************************************  
*   
* ���ߣ�������  
* ˵���� ��ʦ 
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
    public interface IUser_TeacherRepository : IRepository<User_Teacher>  
    {  
  
    }  
    public class User_TeacherRepository : EntityFrameworkRepository<User_Teacher>, IUser_TeacherRepository  
    {  
        public User_TeacherRepository(IRepositoryContext context)  
            : base(context)  
        {   
          
        }  
    }  
}  


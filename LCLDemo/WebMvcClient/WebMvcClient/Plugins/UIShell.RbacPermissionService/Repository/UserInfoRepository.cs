/*******************************************************  
*   
* ���ߣ�������  
* ˵���� �û�������Ϣ 
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
    public interface IUserInfoRepository : IRepository<UserInfo>  
    {  
  
    }  
    public class UserInfoRepository : EntityFrameworkRepository<UserInfo>, IUserInfoRepository  
    {  
        public UserInfoRepository(IRepositoryContext context)  
            : base(context)  
        {   
          
        }  
    }  
}  


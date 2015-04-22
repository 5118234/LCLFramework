using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(UserMD))]  
    public partial class User  
    {  
  
        public class UserMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "��¼����")]  
            public string Name { get; set; }
            [Display(Name = "��¼����")]
            public string Password { get; set; }  
            [Display(Name = "�Ƿ�����")]  
            public bool IsLockedOut { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


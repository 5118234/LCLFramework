using System; 
using System.ComponentModel.DataAnnotations;

namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(UserMD))]  
    public partial class User  
    {  
        public class UserMD  
        {  
            [Display(Name = "��¼����")]  
            public string Name { get; set; }  
            [Display(Name = "��¼����")]
            [Required(ErrorMessage = "���벻��Ϊ��")]
            [StringLength(20, ErrorMessage = "���볤�Ȳ��ܳ���20���ַ�")]
            [DataType(DataType.Password)]
            public string Password { get; set; }  
            [Display(Name = "�Ƿ�����")]  
            public bool IsLockedOut { get; set; }  
        }  
    }  
 
} 


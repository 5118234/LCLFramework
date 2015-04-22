using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(RoleAuthorityMD))]  
    public partial class RoleAuthority  
    {  
  
        public class RoleAuthorityMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "��")]  
            public string BlockKey { get; set; }  
            [Display(Name = "ģ��")]  
            public string ModuleKey { get; set; }  
            [Display(Name = "����")]  
            public string OperationKey { get; set; }  
            [Display(Name = "����")]  
            public int AuthorityType { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


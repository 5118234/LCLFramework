using System; 
using System.ComponentModel.DataAnnotations;

namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(RoleAuthorityMD))]  
    public partial class RoleAuthority  
    {  
        public class RoleAuthorityMD  
        {  
            [Display(Name = "��")]  
            public string BlockKey { get; set; }  
            [Display(Name = "ģ��")]  
            public string ModuleKey { get; set; }  
            [Display(Name = "����")]  
            public string OperationKey { get; set; }  
            [Display(Name = "Url")]  
            public string Url { get; set; }  
            [Display(Name = "����")]  
            public int AuthorityType { get; set; }  
        }  
    }  
 
} 


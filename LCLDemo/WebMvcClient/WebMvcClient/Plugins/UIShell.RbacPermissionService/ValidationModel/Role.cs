using System; 
using System.ComponentModel.DataAnnotations;

namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(RoleMD))]  
    public partial class Role  
    {  
        public class RoleMD  
        {  
            [Display(Name = "����")]  
            public string Name { get; set; }  
            [Display(Name = "����")]  
            public string Remark { get; set; }  
        }  
    }  
 
} 


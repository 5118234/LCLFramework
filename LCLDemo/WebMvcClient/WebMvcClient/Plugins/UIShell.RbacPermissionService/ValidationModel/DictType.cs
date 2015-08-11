using System; 
using System.ComponentModel.DataAnnotations;

namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(DictTypeMD))]  
    public partial class DictType  
    {  
        public class DictTypeMD  
        {  
            [Display(Name = "����")]  
            public string Name { get; set; }  
            [Display(Name = "����")]  
            public string DicDes { get; set; }  
        }  
    }  
 
} 


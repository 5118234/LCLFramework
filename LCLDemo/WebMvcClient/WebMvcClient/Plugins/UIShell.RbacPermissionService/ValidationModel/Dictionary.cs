using System; 
using System.ComponentModel.DataAnnotations;

namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(DictionaryMD))]  
    public partial class Dictionary  
    {  
        public class DictionaryMD  
        {  
            [Display(Name = "����")]  
            public string Name { get; set; }  
            [Display(Name = "ֵ")]  
            public string Value { get; set; }  
            [Display(Name = "����")]  
            public int Order { get; set; }  
        }  
    }  
 
} 


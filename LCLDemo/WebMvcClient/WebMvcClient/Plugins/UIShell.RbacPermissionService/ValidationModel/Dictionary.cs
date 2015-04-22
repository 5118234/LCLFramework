using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(DictionaryMD))]  
    public partial class Dictionary  
    {  
  
        public class DictionaryMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "����")]  
            public string Name { get; set; }  
            [Display(Name = "ֵ")]  
            public string Value { get; set; }  
            [Display(Name = "����")]  
            public int Order { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


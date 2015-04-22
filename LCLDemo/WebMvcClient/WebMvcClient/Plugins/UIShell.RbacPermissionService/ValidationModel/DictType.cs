using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(DictTypeMD))]  
    public partial class DictType  
    {  
  
        public class DictTypeMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "����")]  
            public string Name { get; set; }  
            [Display(Name = "����")]  
            public string DicDes { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


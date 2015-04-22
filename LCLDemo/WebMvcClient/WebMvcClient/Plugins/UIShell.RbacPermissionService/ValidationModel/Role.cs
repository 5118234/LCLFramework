using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(RoleMD))]  
    public partial class Role  
    {  
  
        public class RoleMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "����")]  
            public string Name { get; set; }  
            [Display(Name = "����")]  
            public string Remark { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


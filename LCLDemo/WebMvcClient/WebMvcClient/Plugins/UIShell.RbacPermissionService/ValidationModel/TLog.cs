using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(TLogMD))]  
    public partial class TLog  
    {  
  
        public class TLogMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "��λ")]  
            public Guid Org_Id { get; set; }  
            [Display(Name = "�û�")]  
            public Guid UserId { get; set; }  
            [Display(Name = "����")]  
            public string Content { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


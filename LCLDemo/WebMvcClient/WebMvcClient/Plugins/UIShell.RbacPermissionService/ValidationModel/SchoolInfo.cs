using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(SchoolInfoMD))]  
    public partial class SchoolInfo  
    {  
  
        public class SchoolInfoMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "У������")]  
            public string HeadmasterName { get; set; }  
            [Display(Name = "У���ֻ�")]  
            public string HeadmasterPhone { get; set; }  
            [Display(Name = "У����")]  
            public DateTime SchoolYear { get; set; }  
            [Display(Name = "����֤��")]  
            public string LandCardNo { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


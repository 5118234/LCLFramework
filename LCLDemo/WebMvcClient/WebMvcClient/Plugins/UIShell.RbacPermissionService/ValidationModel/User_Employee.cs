using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(User_EmployeeMD))]  
    public partial class User_Employee  
    {  
        public class User_EmployeeMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "����")]  
            public string HelperCode { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


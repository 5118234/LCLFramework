using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(CompanyInfoMD))]  
    public partial class CompanyInfo  
    {  
  
        public class CompanyInfoMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "��������")]
            public CompanyType CompanyType { get; set; }  
            [Display(Name = "��������")]
            public EconomicType EconomicType { get; set; }  
            [Display(Name = "ע������")]  
            public DateTime RegisterDate { get; set; }  
            [Display(Name = "ע���ʽ�")]
            public double RegisterMoney { get; set; }  
            [Display(Name = "ע���ַ")]  
            public string RegisterAddress { get; set; }  
            [Display(Name = "���˴���")]  
            public string EgalPerson { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


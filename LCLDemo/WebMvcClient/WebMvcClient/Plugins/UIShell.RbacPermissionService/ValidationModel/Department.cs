using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(DepartmentMD))]  
    public partial class Department  
    {  
        public class DepartmentMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "����")]  
            public string HelperCode { get; set; }  
            [Display(Name = "����")]  
            public string Name { get; set; }  
            [Display(Name = "�Ƿ����һ��")]  
            public bool IsLast { get; set; }  
            [Display(Name = "�������")]  
            public int Level { get; set; }  
            [Display(Name = "����·��")]  
            public string NodePath { get; set; }  
            [Display(Name = "����")]  
            public int OrderBy { get; set; }  
            [Display(Name = "��һ��")]  
            public Guid ParentId { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


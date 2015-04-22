using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(UnitInfoMD))]  
    public partial class UnitInfo  
    {  
  
        public class UnitInfoMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "��֯��������")]  
            public string HelperCode { get; set; }  
            [Display(Name = "����")]  
            public string Name { get; set; }  
            [Display(Name = "ȫ��")]  
            public string NameFull { get; set; }  
            [Display(Name = "��������")]  
            public string NameEN { get; set; }  
            [Display(Name = "��������")]  
            public string Email { get; set; }  
            [Display(Name = "�칫�绰")]  
            public string OfficePhone { get; set; }  
            [Display(Name = "����绰")]  
            public string FaxPhone { get; set; }  
            [Display(Name = "��ַ")]  
            public string Address { get; set; }  
            [Display(Name = "��������")]  
            public string ZipCode { get; set; }  
            [Display(Name = "��λ��ַ")]  
            public string HomePage { get; set; }  
            [Display(Name = "����")]  
            public string Remark { get; set; }  
            [Display(Name = "��λ����")]
            public UnitType UnitType { get; set; }  
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


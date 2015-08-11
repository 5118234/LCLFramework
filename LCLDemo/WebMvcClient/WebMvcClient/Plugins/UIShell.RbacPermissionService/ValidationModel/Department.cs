using System;
using System.ComponentModel.DataAnnotations;

namespace UIShell.RbacPermissionService
{
    [Serializable]
    [MetadataType(typeof(DepartmentMD))]
    public partial class Department
    {
        public class DepartmentMD
        {
            [Display(Name = "��������")]
            public int DepartmentType { get; set; }
            [Display(Name = "����")]
            [Required(ErrorMessage = "���Ʋ���Ϊ��")]
            [StringLength(20, ErrorMessage = "���Ƴ��Ȳ��ܳ���20���ַ�")]
            public string Name { get; set; }
            [Display(Name = "�칫�绰")]
            public string OfficePhone { get; set; }
            [Display(Name = "��ַ")]
            public string Address { get; set; }
            [Display(Name = "��Դ")]
            public string Source { get; set; }
            [Display(Name = "����")]
            public string Remark { get; set; }
        }
    }

}


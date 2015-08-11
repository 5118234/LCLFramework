using System;
using System.ComponentModel.DataAnnotations;

namespace UIShell.RbacPermissionService
{
    [Serializable]
    [MetadataType(typeof(XzqyMD))]
    public partial class Xzqy
    {
        public class XzqyMD
        {
            [Display(Name = "��������")]
            public string HelperCode { get; set; }
            [Display(Name = "��������")]
            public string Name { get; set; }
            [Display(Name = "��������")]
            public string Intro { get; set; }
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
        }
    }
}


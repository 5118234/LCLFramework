using System;
using System.ComponentModel.DataAnnotations;

namespace UIShell.RbacPermissionService
{
    [Serializable]
    [MetadataType(typeof(TLogMD))]
    public partial class TLog
    {
        public class TLogMD
        {
            [Display(Name = "����")]
            public string Title { get; set; }
            [Display(Name = "����")]
            public string Content { get; set; }
            [Display(Name = "�û���")]
            public string UserName { get; set; }
            [Display(Name = "������")]
            public string MachineName { get; set; }
            [Display(Name = "ģ����")]
            public string ModuleName { get; set; }
            [Display(Name = "��־����")]
            public EnumLogType LogType { get; set; }
            [Display(Name = "IP��ַ")]
            public string IP { get; set; }
            [Display(Name = "��ַ")]
            public string url { get; set; }
            [Display(Name = "�����")]
            public string Browser { get; set; }
            [Display(Name = "֧��ActiveX")]
            public bool IsActiveX { get; set; }
        }
    }
}


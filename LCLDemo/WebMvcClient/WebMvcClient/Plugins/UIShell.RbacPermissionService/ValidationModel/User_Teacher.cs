using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(User_TeacherMD))]  
    public partial class User_Teacher  
    {  
        public class User_TeacherMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "�Ƿ�ȡ�ý�ʦ�ʸ�֤��")]  
            public bool IsGetZGZ { get; set; }  
            [Display(Name = "ȡ�ý�ʦ�ʸ�֤����ʱ��")]  
            public DateTime GetZGZTime { get; set; }  
            [Display(Name = "��ʦ�ʸ�֤���")]  
            public string ZGZNo { get; set; }  
            [Display(Name = "������ȼ�")]  
            public string ComputerRank { get; set; }  
            [Display(Name = "���ѧλ")]  
            public int DegreeID { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


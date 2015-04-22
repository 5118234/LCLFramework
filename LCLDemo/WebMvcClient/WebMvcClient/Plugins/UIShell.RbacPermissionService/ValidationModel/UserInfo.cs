using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(UserInfoMD))]  
    public partial class UserInfo  
    {  
        public class UserInfoMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "��ʵ����")]  
            public string TName { get; set; }  
            [Display(Name = "������")]  
            public string CengYongMing { get; set; }  
            [Display(Name = "����ȫƴ")]  
            public string NameQuanPin { get; set; }  
            [Display(Name = "�Ա�")]  
            public string Sex { get; set; }  
            [Display(Name = "��������")]  
            public string Birthday { get; set; }  
            [Display(Name = "����")]  
            public int NationalID { get; set; }  
            [Display(Name = "������ò")]  
            public int PoliticalID { get; set; }  
            [Display(Name = "����")]  
            public string NativeID { get; set; }  
            [Display(Name = "��Ƭ")]  
            public string UserPhoto { get; set; }  
            [Display(Name = "���֤��")]  
            public string IdCard { get; set; }  
            [Display(Name = "�绰")]  
            public string Telephone { get; set; }  
            [Display(Name = "��������")]  
            public string Email { get; set; }  
            [Display(Name = "�û�QQ")]  
            public string UserQQ { get; set; }  
        }  
    }  
 
} 


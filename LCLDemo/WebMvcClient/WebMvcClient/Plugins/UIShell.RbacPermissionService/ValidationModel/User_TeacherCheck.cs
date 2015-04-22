using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(User_TeacherCheckMD))]  
    public partial class User_TeacherCheck  
    {  
        public class User_TeacherCheckMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "ѧУ���ͨ��")]  
            public bool IsPassSchool { get; set; }  
            [Display(Name = "ѧУ�����")]  
            public Guid SchoolPassBy { get; set; }  
            [Display(Name = "ѧУ���ʱ��")]  
            public DateTime SchoolPassTime { get; set; }  
            [Display(Name = "ѧУ������")]  
            public string SchoolPassComments { get; set; }  
            [Display(Name = "�ؾ����ͨ��")]  
            public bool IsPassCounty { get; set; }  
            [Display(Name = "�ؾ������")]  
            public Guid CountyPassBy { get; set; }  
            [Display(Name = "�ؾ����ʱ��")]  
            public DateTime CountyPassTime { get; set; }  
            [Display(Name = "�ؾ�������")]  
            public string CountyPassComments { get; set; }  
            [Display(Name = "�о����ͨ��")]  
            public bool IsPassCity { get; set; }  
            [Display(Name = "�о����ʱ��")]  
            public DateTime CitylPassTime { get; set; }  
            [Display(Name = "�о������")]  
            public Guid CityPassBy { get; set; }  
            [Display(Name = "�о�������")]  
            public string CityPassComments { get; set; }  
            [Display(Name = "ʡ�����ͨ��")]  
            public bool IsPassProvince { get; set; }  
            [Display(Name = "ʡ�������")]  
            public Guid ProvincePassBy { get; set; }  
            [Display(Name = "ʡ�����ʱ��")]  
            public DateTime ProvincePassTime { get; set; }  
            [Display(Name = "ʡ��������")]  
            public string ProvincePassComments { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
} 


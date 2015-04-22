using System; 
using System.ComponentModel.DataAnnotations; 
using System.Linq; 
using System.Text; 
 
namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(ScheduledEventsMD))]  
    public partial class ScheduledEvents  
    {  
  
        public class ScheduledEventsMD  
        {  
            [Display(Name = "���")]  
            public Guid ID { get; set; }  
            [Display(Name = "�ƻ���������")]  
            public string Key { get; set; }  
            [Display(Name = "�ϴ�ִ��ʱ��")]  
            public DateTime Lastexecuted { get; set; }  
            [Display(Name = "��������")]  
            public string ServerName { get; set; }  
            [Display(Name = "���ʱ��")]  
            public DateTime AddDate { get; set; }  
            [Display(Name = "����ʱ��")]  
            public DateTime UpdateDate { get; set; }  
        }  
    }  
 
} 


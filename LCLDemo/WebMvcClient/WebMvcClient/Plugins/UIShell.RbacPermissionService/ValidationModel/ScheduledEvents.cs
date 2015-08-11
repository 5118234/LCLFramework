using System; 
using System.ComponentModel.DataAnnotations;

namespace UIShell.RbacPermissionService 
{ 
    [Serializable] 
    [MetadataType(typeof(ScheduledEventsMD))]  
    public partial class ScheduledEvents  
    {  
        public class ScheduledEventsMD  
        {  
            [Display(Name = "�ƻ���������")]  
            public string Key { get; set; }  
            [Display(Name = "�ϴ�ִ��ʱ��")]  
            public DateTime Lastexecuted { get; set; }  
            [Display(Name = "��������")]  
            public string ServerName { get; set; }  
        }  
    }  
 
} 


using System;
using UIShell.RbacPermissionService;

namespace UIShell.HeatMeteringService
{
    ///<summary>
    /// ����վ 
    ///</summary>
    [Serializable]
    public partial class HM_HeatPlant:BaseTreeModel
    {
        /// <summary>
        /// ����վ
        /// </summary>
        public int PID { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public string NameShort { get; set; }
        /// <summary>
        /// ��ַ
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string AdminName { get; set; }
        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark { get; set; }
    }
}

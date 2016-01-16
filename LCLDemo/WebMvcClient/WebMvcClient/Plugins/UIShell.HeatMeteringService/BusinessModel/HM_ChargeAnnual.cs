using System;
using UIShell.RbacPermissionService;

namespace UIShell.HeatMeteringService
{
    ///<summary>
    /// ��ȹ��ȵ��� 
    ///</summary>
    [Serializable]
    public partial class HM_ChargeAnnual : BaseModel
    {
        /// <summary>
        /// ��ʶ����
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// �Ƿ�ǰ�������
        /// </summary>
        public bool IsOpen { get; set; }
        /// <summary>
        /// ���ȿ�ʼʱ��
        /// </summary>
        public DateTime BeginDate { get; set; }
        /// <summary>
        /// ���Ƚ���ʱ��
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public int GongreDay { get; set; }
        /// <summary>
        /// ���ɿ�ʼ����
        /// </summary>
        public DateTime DnaBeginDate { get; set; }
        /// <summary>
        /// ΥԼ�����
        /// </summary>
        public double BreakMoney { get; set; }
        /// <summary>
        /// ͣ�Ȼ����ѱ���
        /// </summary>
        public double StopHeatRatio { get; set; }
        /// <summary>
        ///�̶��ȷѱ���
        /// </summary>
        public double Fixedportion { get; set; }
        /// <summary>
        ///����
        /// </summary>
        public double Gongjian { get; set; }
        /// <summary>
        ///����
        /// </summary>
        public double Resident { get; set; }
        /// <summary>
        ///����
        /// </summary>
        public double Dishang { get; set; }
        /// <summary>
        ///����1
        /// </summary>
        public double Gongjian1 { get; set; }
        /// <summary>
        ///����1
        /// </summary>
        public double Resident1 { get; set; }
        /// <summary>
        ///����1
        /// </summary>
        public double Dishang1 { get; set; }
    }
}

using System;
using UIShell.RbacPermissionService;

namespace UIShell.HeatMeteringService
{
    ///<summary>
    /// �ȼ�����ů���շѵ�
    ///</summary>
    [Serializable]
    public partial class HM_ClientCharge : BaseModel
    {
        /// <summary>
        /// �ȼ�����ů�ѽ��㵥
        /// </summary>
        public HM_ClientHeatCharge ClientHeatCharge { get; set; }
        /// <summary>
        /// �ͻ�
        /// </summary>
        public HM_ClientInfo ClientInfo { get; set; }
        /// <summary>
        /// ��ȹ��ȵ���
        /// </summary>
        public HM_ChargeAnnual ChargeAnnual { get; set; }
        /// <summary>
        /// �շ�Ա
        /// </summary>
        public HM_ChargeUser ChargeUser { get; set; }  
        /// <summary>
        /// ���ȿ�ʼ����
        /// </summary>
        public double BeginHeat { get; set; }
        /// <summary>
        /// ���Ƚ�������
        /// </summary>
        public double EndHeat { get; set; }
        /// <summary>
        /// ��������KMH��
        /// </summary>
        public double UseHeat { get; set; }
        /// <summary>
        /// �����ȷ�
        /// </summary>
        public double MoneyHeat { get; set; }
        /// <summary>
        /// �����ȷ�
        /// </summary>
        public double MoneyBaseHeat { get; set; }
        /// <summary>
        /// Ԥ�ս��
        /// </summary>
        public double MoneyAdvance { get; set; }
        /// <summary>
        /// �˲����
        /// </summary>
        public double MoneyOrRefunded { get; set; }
    }
}

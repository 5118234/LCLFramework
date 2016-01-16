using System;
using UIShell.RbacPermissionService;

namespace UIShell.HeatMeteringService
{
    ///<summary>
    ///�ͻ���Ϣ 
    ///</summary>
    [Serializable]
    public partial class HM_ClientInfo : BaseModel
    {
        /// <summary>
        /// ��ȹ��ȵ���
        /// </summary>
        public HM_ChargeAnnual ChargeAnnual { get; set; }

        /// <summary>
        /// ��Ԫ
        /// </summary>
        public HM_Village Village { get; set; }
        /// <summary>
        /// �ͻ�����
        /// </summary>
        public string ClientType { get; set; }
        /// <summary>
        /// ȡů����
        /// </summary>
        public int HeatType { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string HelpeCode { get; set; }
        /// <summary>
        /// ���俨��
        /// </summary>
        public string Cardno { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// �����û���
        /// </summary>
        public string NetInName { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public string RoomNumber { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public double BuildArea { get; set; }
        /// <summary>
        /// ���ڽ������
        /// </summary>
        public double InsideBuildArea { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public double Superelevation { get; set; }
        /// <summary>
        /// ��̨״̬
        /// </summary>
        public int BalconyState { get; set; }
        /// <summary>
        /// ��̨���
        /// </summary>
        public int BalconyArea { get; set; }
        /// <summary>
        /// ��̨��ů״̬
        /// </summary>
        public int BalconyHeatState { get; set; }
        /// <summary>
        /// ��̨�շ����
        /// </summary>
        public int BalconyHeatArea { get; set; }
        /// <summary>
        /// ��¥�в����
        /// </summary>
        public double InterlayerArea { get; set; }
        /// <summary>
        /// ��¥�в��ů״̬
        /// </summary>
        public int InterlayerState { get; set; }
        /// <summary>
        /// ��¥�в��շ����
        /// </summary>
        public double InterlayerHeatArea { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public double InsideArea { get; set; }
        /// <summary>
        /// �շ����
        /// </summary>
        public double HeatArea { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public int UnitPriceType { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime NetworkDate { get; set; }
        /// <summary>
        /// ����/����
        /// </summary>
        public bool IsNetwork { get; set; }
        /// <summary>
        /// ��ʼ��ů����
        /// </summary>
        public DateTime BeginHeatDate { get; set; }
        /// <summary>
        /// ����Դ��
        /// </summary>
        public string TotalHeatSourceFactory { get; set; }
        /// <summary>
        /// ��Դ
        /// </summary>
        public string HeatSource { get; set; }
        /// <summary>
        /// ¥��
        /// </summary>
        public int Floor { get; set; }
        /// <summary>
        ///  �߱�
        /// </summary>
        public string LineType { get; set; }
        /// <summary>
        /// ��ͣ/ǿͣ/����
        /// </summary>
        public int HeatState { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// ������ַ
        /// </summary>
        public string JobAddress { get; set; }
        /// <summary>
        /// ��ͥ��ַ
        /// </summary>
        public string HomeAddress { get; set; }
        /// <summary>
        /// �Ա�
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// ���֤��
        /// </summary>
        public string IDCard { get; set; }

    }
}

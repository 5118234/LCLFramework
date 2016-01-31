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
        /// ������
        /// </summary>
        public string HelpeCode { get; set; }    
        /// <summary>
        /// �����
        /// </summary>
        public string RoomNumber { get; set; }
        /// <summary>
        /// ���ƺ�
        /// </summary>
        public string Cardno { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// �շ����
        /// </summary>
        public double HeatArea { get; set; }
        /// <summary>
        /// ¥��
        /// </summary>
        public int Floor { get; set; }
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

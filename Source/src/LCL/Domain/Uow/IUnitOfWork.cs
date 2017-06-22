using System;

namespace LCL.Domain.Uow
{
    /// <summary>
    /// ҵ��Ԫ�����ӿ�
    /// </summary>
    public interface IUnitOfWork
    {
        bool DistributedTransactionSupported { get; }
        /// <summary>
        ///  ��ȡ ��ǰ��Ԫ�����Ƿ��ѱ��ύ  
        /// </summary>
        bool Committed { get; }
        /// <summary>
        /// �ύ��ǰ��Ԫ�����Ľ��  
        /// </summary>
        void Commit();
        /// <summary>
        /// �ѵ�ǰ��Ԫ�����ع���δ�ύ״̬  
        /// </summary>
        void Rollback();
    }
}
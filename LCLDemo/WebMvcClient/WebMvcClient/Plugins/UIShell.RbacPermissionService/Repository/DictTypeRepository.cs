/*******************************************************  
*   
* ���ߣ�������  
* ˵����  
* ���л�����.NET 4.5.0  
* �汾�ţ�1.0.0  
*   
* ��ʷ��¼��  
*    �����ļ� ������ 20154��18�� ������ 
*   
*******************************************************/
using LCL.Repositories;
using LCL.Repositories.EntityFramework;
using System;
using System.Collections.Generic;

namespace UIShell.RbacPermissionService
{
    public interface IDictTypeRepository : IRepository<DictType>
    {
        string GetByName(Guid guid);
    }
    public class DictTypeRepository : EntityFrameworkRepository<DictType>, IDictTypeRepository
    {
        private string className = "";
        private string cacheKey = "";
        public DictTypeRepository(IRepositoryContext context)
            : base(context)
        {
            this.className = typeof(DictType).Name;
            this.cacheKey = "LCL_Cache_" + className;
        }
        protected override void DoRemove(object keyValue)
        {
            DbFactory.DBA.ExecuteText("delete from Dictionary where DictType_ID='" + keyValue + "'");
            base.DoRemove(keyValue);
        }
        public string GetByName(Guid id)
        {
            try
            {
                var model = this.GetByKey(id);
                return model.Name;
            }
            catch (Exception)
            {
                return "����";
            }
        }
    }
}


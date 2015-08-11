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
        List<Dictionary> GetDictionaryList(string dicTypeName);
        List<Dictionary> GetModelList(params string[] dictypeId);
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
        public List<Dictionary> GetDictionaryList(string dicTypeName)
        {
            throw new NotImplementedException();
        }
        public List<Dictionary> GetModelList(params string[] dictypeId)
        {
            throw new NotImplementedException();
        }
    }
}  


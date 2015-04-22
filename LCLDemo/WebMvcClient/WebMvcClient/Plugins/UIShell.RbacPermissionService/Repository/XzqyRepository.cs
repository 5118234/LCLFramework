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
using LCL;
using LCL.Repositories;
using LCL.Repositories.EntityFramework;
using LCL.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;  
  
namespace UIShell.RbacPermissionService  
{  
    public interface IXzqyRepository : IRepository<Xzqy>  
    {
        List<Xzqy> GetXzqyRootsList();
        List<Xzqy> GetXzqyChildList(Guid? pid);

        List<Xzqy> GetFull();
    }  
    public class XzqyRepository : EntityFrameworkRepository<Xzqy>, IXzqyRepository  
    {  
        public XzqyRepository(IRepositoryContext context)  
            : base(context)  
        {   
          
        }

        public List<Xzqy> GetXzqyChildList(Guid? pid)
        {
            if (pid == null) pid = Guid.Empty;
            ISpecification<Xzqy> spec = Specification<Xzqy>.Eval(p => p.ParentId == Guid.Empty);
            ISpecification<Xzqy> spec1 = Specification<Xzqy>.Eval(p => p.ParentId == pid);
            IEnumerable<Xzqy> list = this.FindAll(spec);
            if (pid != Guid.Empty)
            {
                list = this.FindAll(spec1);
            }
            return list.ToList();
        }
        public List<Xzqy> GetXzqyRootsList()
        {
            ISpecification<Xzqy> spec =
               Specification<Xzqy>.Eval(p => p.ParentId == Guid.Empty);
            var list = this.FindAll(spec, e => e.OrderBy, SortOrder.Ascending);

            return list.ToList();
        }
        public List<Xzqy> GetFull()
        {
            var list = this.FindAll(e => e.NodePath, SortOrder.Ascending);

            return list.ToList();
        }
    }  
}  


using LCL;
/*******************************************************  
*   
* ���ߣ�������  
* ˵���� ���� 
* ���л�����.NET 4.5.0  
* �汾�ţ�1.0.0  
*   
* ��ʷ��¼��  
*    �����ļ� ������ 20154��22�� ������ 
*   
*******************************************************/
using LCL.Repositories;
using LCL.Repositories.EntityFramework;
using LCL.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIShell.RbacPermissionService
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        List<Department> GetUnitDepartment(Guid unitId);
    }
    public class DepartmentRepository : EntityFrameworkRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(IRepositoryContext context)
            : base(context)
        {

        }
        public List<Department> GetUnitDepartment(Guid unitId)
        {
            ISpecification<Department> spec = Specification<Department>.Eval(p => p.UnitInfo.ID == unitId);
            var list = this.FindAll(spec, e => e.NodePath, SortOrder.Ascending);

            return list.ToList();
        }
    }
}


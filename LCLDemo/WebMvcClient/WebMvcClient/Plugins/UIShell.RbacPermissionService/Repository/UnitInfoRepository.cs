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
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCL;
  
namespace UIShell.RbacPermissionService  
{  
    public interface IUnitInfoRepository : IRepository<UnitInfo>  
    {
        List<SchoolInfoPageListViewModel> GetSchoolInfoList();
        List<CompanyInfoPageListViewModel> GetCompanyInfoList();
    }  
    public class UnitInfoRepository : EntityFrameworkRepository<UnitInfo>, IUnitInfoRepository  
    {  
        public UnitInfoRepository(IRepositoryContext context)  
            : base(context)  
        {   
          
        }
        public List<SchoolInfoPageListViewModel> GetSchoolInfoList()
        {
            string sql = @"SELECT  u.ID ,
        HelperCode ,
        u.Name ,
        u.NameFull ,
        u.NameEN ,
        Email ,
        OfficePhone ,
        FaxPhone ,
        Address ,
        ZipCode ,
        HomePage ,
        Remark ,
        UnitType ,
        HeadmasterName ,
        HeadmasterPhone ,
        SchoolYear ,
        LandCardNo,u.UpdateDate
FROM  UnitInfo u
INNER JOIN SchoolInfo s ON u.ID = s.UnitInfo_ID";
            DataTable dt = DbFactory.DBA.QueryDataTable(sql);
            var arr = dt.ToArray<SchoolInfoPageListViewModel>();
            var list = arr.ToList();
            return list;
        }


        public List<CompanyInfoPageListViewModel> GetCompanyInfoList()
        {
            string sql = @"SELECT  u.ID ,
        HelperCode ,
        u.Name ,
        u.NameFull ,
        u.NameEN ,
        Email ,
        OfficePhone ,
        FaxPhone ,
        Address ,
        ZipCode ,
        HomePage ,
        Remark ,
        EconomicType ,
        RegisterDate ,
        RegisterMoney ,
        RegisterAddress ,
        EgalPerson ,
        u.UpdateDate
FROM    UnitInfo u
        INNER JOIN CompanyInfo s ON u.ID = s.UnitInfo_ID";
            DataTable dt = DbFactory.DBA.QueryDataTable(sql);
            var arr = dt.ToArray<CompanyInfoPageListViewModel>();
            var list = arr.ToList();
            return list;
        }
    }  
}  


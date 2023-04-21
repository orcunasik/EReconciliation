using EReconciliationAPI.Core.DataAccess.EntityFramework;
using EReconciliationAPI.Core.Entities.Concrete;
using EReconciliationAPI.DataAccess.Abstract;
using EReconciliationAPI.DataAccess.Concrete.EntityFramework.Context;
using EReconciliationAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.DataAccess.Concrete.EntityFramework
{
    public class EfCompanyDal : EfEntityRepository<Company, EReconciliationContext>, ICompanyDal
    {
        public void UserCompanyAdd(int userId, int companyId)
        {
            using (var context = new EReconciliationContext() )
            {
                UserCompany userCompany = new()
                {
                    UserId = userId,
                    CompanyId = companyId,
                    AddedAt = DateTime.Now,
                    IsActive = true
                };
                context.UserCompanies.Add(userCompany);
                context.SaveChanges();
            }
        }
    }
}

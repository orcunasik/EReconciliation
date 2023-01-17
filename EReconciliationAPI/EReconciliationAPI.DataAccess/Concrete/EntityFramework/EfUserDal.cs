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
    public class EfUserDal : EfEntityRepository<User, EReconciliationContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user, int companyId)
        {
            using (var context = new EReconciliationContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.CompanyId == companyId 
                                    && userOperationClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };
                return result.ToList();
            }
        }
    }
}

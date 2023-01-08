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
    public class EfUserCompanyDal : EfEntityRepository<UserCompany, EReconciliationContext>, IUserCompanyDal
    {
    }
}

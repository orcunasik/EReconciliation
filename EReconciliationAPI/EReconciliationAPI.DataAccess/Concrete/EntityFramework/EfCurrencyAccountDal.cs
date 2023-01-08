using EReconciliationAPI.Core.DataAccess.EntityFramework;
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
    public class EfCurrencyAccountDal : EfEntityRepository<CurrencyAccount, EReconciliationContext>, ICurrencyAccountDal
    {
    }
}

using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.Business.Concrete
{
    public class CurrencyAccountService : ICurrencyAccountService
    {
        private readonly ICurrencyAccountDal _currencyAccountDal;

        public CurrencyAccountService(ICurrencyAccountDal currencyAccountDal)
        {
            _currencyAccountDal = currencyAccountDal;
        }
    }
}

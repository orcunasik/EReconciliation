using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.Business.Concrete
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyDal _currencyDal;

        public CurrencyService(ICurrencyDal currencyDal)
        {
            _currencyDal = currencyDal;
        }
    }
}

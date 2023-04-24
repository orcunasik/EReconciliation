using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.DataAccess.Abstract;

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

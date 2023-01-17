using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.Business.Concrete
{
    public class AccountReconciliationService : IAccountReconciliationService
    {
        private readonly IAccountReconciliationDal _accountReconciliationDal;

        public AccountReconciliationService(IAccountReconciliationDal accountReconciliationDal)
        {
            _accountReconciliationDal = accountReconciliationDal;
        }
    }
}

using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.Business.Concrete
{
    public class AccountReconciliationDetailService : IAccountReconciliationDetailService
    {
        private readonly IAccountReconciliationDetailDal _accountReconciliationDetail;

        public AccountReconciliationDetailService(IAccountReconciliationDetailDal accountReconciliationDetail)
        {
            _accountReconciliationDetail = accountReconciliationDetail;
        }
    }
}

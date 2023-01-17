using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.Business.Concrete
{
    public class MailParameterService : IMailParameterService
    {
        private readonly IMailParameterDal _mailParameterDal;

        public MailParameterService(IMailParameterDal mailParameterDal)
        {
            _mailParameterDal = mailParameterDal;
        }
    }
}

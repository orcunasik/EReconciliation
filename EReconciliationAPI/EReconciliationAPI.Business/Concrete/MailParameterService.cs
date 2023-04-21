using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.Business.Constants;
using EReconciliationAPI.Core.Utilities.Results.Abstract;
using EReconciliationAPI.Core.Utilities.Results.Concrete;
using EReconciliationAPI.DataAccess.Abstract;
using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.Business.Concrete
{
    public class MailParameterService : IMailParameterService
    {
        private readonly IMailParameterDal _mailParameterDal;

        public MailParameterService(IMailParameterDal mailParameterDal)
        {
            _mailParameterDal = mailParameterDal;
        }

        public IDataResult<MailParameter> Get(int companyId)
        {
            return new SuccessDataResult<MailParameter>(_mailParameterDal.Get(p => p.CompanyId == companyId));
        }

        public IResult Update(MailParameter mailParameter)
        {
            var result = Get(mailParameter.CompanyId);
            if (result.Data is null)
            {
                _mailParameterDal.Add(mailParameter);
            }
            else
            {
                result.Data.SMTP = mailParameter.SMTP;
                result.Data.Port = mailParameter.Port;
                result.Data.SSL = mailParameter.SSL;
                result.Data.Email = mailParameter.Email;
                result.Data.Password = mailParameter.Password;
                _mailParameterDal.Update(result.Data);
            }
            return new SuccessResult(Messages.MailParameterUpdated);
        }
    }
}

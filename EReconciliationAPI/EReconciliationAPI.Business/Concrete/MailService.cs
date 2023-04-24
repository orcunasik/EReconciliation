using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.Business.Constants;
using EReconciliationAPI.Core.Utilities.Results.Abstract;
using EReconciliationAPI.Core.Utilities.Results.Concrete;
using EReconciliationAPI.DataAccess.Abstract;
using EReconciliationAPI.Entities.Dtos;

namespace EReconciliationAPI.Business.Concrete
{
    public class MailService : IMailService
    {
        private readonly IMailDal _mailDal;

        public MailService(IMailDal mailDal)
        {
            _mailDal = mailDal;
        }

        public IResult SendMail(SendMailDto sendMailDto)
        {
            _mailDal.SendMail(sendMailDto);
            return new SuccessResult(Messages.MailSendSuccessful);
        }
    }
}

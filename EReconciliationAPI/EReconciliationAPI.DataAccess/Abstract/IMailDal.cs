using EReconciliationAPI.Entities.Dtos;

namespace EReconciliationAPI.DataAccess.Abstract
{
    public interface IMailDal
    {
        void SendMail(SendMailDto sendMailDto);
    }
}

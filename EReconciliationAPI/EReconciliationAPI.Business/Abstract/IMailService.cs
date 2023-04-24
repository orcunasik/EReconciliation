using EReconciliationAPI.Core.Utilities.Results.Abstract;
using EReconciliationAPI.Entities.Dtos;

namespace EReconciliationAPI.Business.Abstract
{
    public interface IMailService
    {
        IResult SendMail(SendMailDto sendMailDto);
    }
}

using EReconciliationAPI.Core.Utilities.Results.Abstract;
using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.Business.Abstract
{
    public interface IMailParameterService
    {
        IResult Update(MailParameter mailParameter);
        IDataResult<MailParameter> Get(int companyId);
    }
}

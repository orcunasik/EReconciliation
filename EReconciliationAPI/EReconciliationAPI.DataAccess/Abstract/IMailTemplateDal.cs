using EReconciliationAPI.Core.DataAccess;
using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.DataAccess.Abstract
{
    public  interface IMailTemplateDal : IEntityRepository<MailTemplate>
    {
    }
}

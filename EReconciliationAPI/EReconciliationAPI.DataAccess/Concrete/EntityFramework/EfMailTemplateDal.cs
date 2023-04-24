using EReconciliationAPI.Core.DataAccess.EntityFramework;
using EReconciliationAPI.DataAccess.Abstract;
using EReconciliationAPI.DataAccess.Concrete.EntityFramework.Context;
using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.DataAccess.Concrete.EntityFramework
{
    public class EfMailTemplateDal : EfEntityRepository<MailTemplate,EReconciliationContext>, IMailTemplateDal
    {
    }
}

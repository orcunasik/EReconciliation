using EReconciliationAPI.Core.DataAccess;
using EReconciliationAPI.Core.DataAccess.EntityFramework;
using EReconciliationAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
        
    }
}

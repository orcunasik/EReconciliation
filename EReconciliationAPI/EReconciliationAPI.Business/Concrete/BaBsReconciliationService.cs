using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.Business.Concrete
{
    public class BaBsReconciliationService : IBaBsReconciliationService
    {
        private readonly IBaBsReconciliationDal _baBsReconciliationDal;

        public BaBsReconciliationService(IBaBsReconciliationDal baBsReconciliationDal)
        {
            _baBsReconciliationDal = baBsReconciliationDal;
        }
    }
}

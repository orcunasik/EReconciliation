using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.Business.Concrete
{
    public class BaBsReconciliationDetailService : IBaBsReconciliationDetailService
    {
        private readonly IBaBsReconciliationDetailDal _baBsReconciliationDetailDal;
public BaBsReconciliationDetailService(IBaBsReconciliationDetailDal baBsReconciliationDetailDal)
        {
            _baBsReconciliationDetailDal = baBsReconciliationDetailDal;
        }
    }
}

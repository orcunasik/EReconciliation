﻿using EReconciliationAPI.Core.DataAccess;
using EReconciliationAPI.Core.Entities.Concrete;
using EReconciliationAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.DataAccess.Abstract
{
    public interface IAccountReconciliationDetailDal : IEntityRepository<AccountReconciliationDetail>
    {
    }
}

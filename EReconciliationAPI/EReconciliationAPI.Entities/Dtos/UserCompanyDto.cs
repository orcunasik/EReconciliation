﻿using EReconciliationAPI.Core.Entities;
using EReconciliationAPI.Core.Entities.Concrete;

namespace EReconciliationAPI.Entities.Dtos
{
    public class UserCompanyDto : User,IDto
    {
        public int CompanyId { get; set; }
    }
}

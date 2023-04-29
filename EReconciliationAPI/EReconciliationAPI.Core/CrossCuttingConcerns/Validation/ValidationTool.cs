﻿using FluentValidation;
using FluentValidation.Results;

namespace EReconciliationAPI.Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            ValidationContext<object> context = new ValidationContext<object>(entity);
            ValidationResult result = validator.Validate(context);
            if (!result.IsValid)
                throw new ValidationException(result.Errors);
        }
    }
}

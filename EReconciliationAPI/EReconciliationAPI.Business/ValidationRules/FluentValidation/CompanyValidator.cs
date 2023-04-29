using EReconciliationAPI.Entities.Concrete;
using FluentValidation;

namespace EReconciliationAPI.Business.ValidationRules.FluentValidation
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithName("Şirket Adı").WithMessage("{PropertyName} Boş Bırakılmamalıdır!")
                                .MinimumLength(5).WithName("Şirket Adı").WithMessage("{PropertyName} En Az 5 Karakter Olmalıdır!");

            RuleFor(c => c.Address).NotEmpty().WithName("Şirket Adresi").WithMessage("{PropertyName}  Boş Bırakılmamalıdır!");
        }
    }
}

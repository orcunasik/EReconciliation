using EReconciliationAPI.Core.Entities.Concrete;
using FluentValidation;

namespace EReconciliationAPI.Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithName("Kullancı Adı").WithMessage("{PropertyName} Boş Bırakılmamalıdır!")
                .MinimumLength(4).WithName("Kullancı Adı").WithMessage("{PropertyName} En Az 4 Karakter Olmalıdır!");

            RuleFor(u => u.Email).NotEmpty().WithName("Email Adresi").WithMessage("{PropertyName} Boş Bırakılmamalıdır!")
                                .EmailAddress().WithName("Email Adresi").WithMessage(" Geçerli Bir{PropertyName} Yazılmalıdır! Ex:example@gmail.com");

        }
    }
}

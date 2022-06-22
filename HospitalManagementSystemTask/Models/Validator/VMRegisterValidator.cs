using FluentValidation;
using HospitalManagementSystemTask.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Models.Validator
{
    public class VMRegisterValidator : AbstractValidator<ViewModelRegister>
    {
        public VMRegisterValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Tam ad daxil edilməlidir")
             .Matches("[A-Z]")
            .Matches("[a-z]")
                .WithMessage("Invalid format.");
            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Elektron poçt ünvanı daxil edilməyib")
              .EmailAddress().WithMessage("Format düzgün seçilməyib.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifrə daxil edilməyib")
                .Length(8, 20).WithMessage("Şifrəniz Min 8 Max 20 sinvoldan ibarət olmalıdır")
            .Matches("[^a-zA-Z0-9]").WithMessage("Format düzgün seçilməyib.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Daxil etdiniz şifrələr tutuşmur")
               .Length(8, 20).WithMessage("Şifrəniz Min 8 Max 20 sinvoldan ibarət olmalıdır")
               .Equal(x => x.Password)
               .When(x => !String.IsNullOrWhiteSpace(x.Password))
           .Matches("[^a-zA-Z0-9]").WithMessage("Format düzgün seçilməyib.");
        }
    }
}

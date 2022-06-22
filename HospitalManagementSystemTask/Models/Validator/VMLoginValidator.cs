using FluentValidation;
using HospitalManagementSystemTask.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Models.Validator
{
    public class VMLoginValidator : AbstractValidator<ViewModelLogin>
    {
        public VMLoginValidator()
        {
            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Elektron poçt ünvanı daxil edilməyib")
                .EmailAddress().WithMessage("Format düzgün seçilməyib.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifrə daxil ediləyib")
                .Length(8, 20).WithMessage("Şifrəniz Min 8 Max 20 sinvoldan ibarət  olmalıdır")
            .Matches("[^a-zA-Z0-9]").WithMessage("Format düzgün seçilməyib.");
        }
    }
}

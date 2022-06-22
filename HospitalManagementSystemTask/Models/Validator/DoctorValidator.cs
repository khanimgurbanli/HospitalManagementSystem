using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Models.Validator
{
    public class DoctorValidator : AbstractValidator<Doctor>
    {
        public DoctorValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad daxil edilməyib")
                .Length(3, 30).WithMessage("Ad Min 3 Max 30 sinvoldan ibarət  olmalıdır");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad daxil edilməyib")
                .Length(3, 30).WithMessage("Soyad Min 3 Max 30 sinvoldan ibarət  olmalıdır");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş daxil edilməyib");
            RuleFor(x => x.Experience).NotEmpty().WithMessage("Təcrübə daxil edilməyib.");
        }

    }
}

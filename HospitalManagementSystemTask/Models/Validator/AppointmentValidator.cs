using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Models.Validator
{
    public class AppointmentValidator : AbstractValidator<Appointment>
    {
        public AppointmentValidator()
        {
            RuleFor(x => x.PasientName).NotEmpty().WithMessage("Ad daxil edilməyib")
                .Length(3, 30).WithMessage("Ad Min 3 Max 30 sinvoldan ibarət  olmalıdır");
            RuleFor(x => x.PasientSurname).NotEmpty().WithMessage("Soyad daxil edilməyib")
                .Length(3, 30).WithMessage("Soyad Min 3 Max 30 sinvoldan ibarət  olmalıdır");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş daxil edilməyib");
            RuleFor(x => x.Tel).NotEmpty().WithMessage("Əlaqə nömrəsi daxil edilməyib.");
            RuleFor(x => x.Disease).NotEmpty().WithMessage("Xəstəlik daxil edilməyib.");
        }

    }
}

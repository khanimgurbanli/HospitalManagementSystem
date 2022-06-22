using HospitalManagementSystemTask.Data.Base;
using HospitalManagementSystemTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Data.Services
{
    public interface IAppointmentService : IEntityBaseRepository<Appointment>
    {
    }
}

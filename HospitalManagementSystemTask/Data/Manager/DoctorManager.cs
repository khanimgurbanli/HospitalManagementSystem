using HospitalManagementSystemTask.Data.Base;
using HospitalManagementSystemTask.Data.Context;
using HospitalManagementSystemTask.Data.Services;
using HospitalManagementSystemTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Data.Manager
{
    public class DoctorManager : EntityBaseRepository<Doctor>, IDoctorService
    {
        public DoctorManager(AppDbContext context) : base(context) { }
    }
}

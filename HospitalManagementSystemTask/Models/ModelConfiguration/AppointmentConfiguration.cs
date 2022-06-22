using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Models.ModelConfiguration
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.PasientName).IsRequired();
            builder.Property(x => x.PasientSurname).IsRequired();
            builder.Property(x => x.Tel).IsRequired();
            builder.Property(x => x.Disease).IsRequired();
            builder.Property(x => x.DoctorId).IsRequired();
            builder.HasOne(x => x.Doctor).WithMany(x => x.Appointments).HasForeignKey(x => x.DoctorId);
        }
    }
}

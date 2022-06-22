using HospitalManagementSystemTask.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Models
{
    public class Appointment : IEntityBase
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string PasientName { get; set; }
        public string PasientSurname { get; set; }
        public int Age { get; set; }
        public string Tel { get; set; }
        public string Disease { get; set; }
        public DateTime DateAndTime { get; set; }

        //Relationship
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }



    }
}

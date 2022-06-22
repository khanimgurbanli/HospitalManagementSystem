using HospitalManagementSystemTask.Data.Base;
using HospitalManagementSystemTask.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Models
{
    public class Doctor : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public byte Experience { get; set; }

        //Enum
        public Position Position { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Server.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public DateTime BirthDate { get; set; }
        public int Weight { get; set; }
        public string BloodGroup { get; set; }
        public string Mobile { get; set; }
        public string GuardianName { get; set; }
        public string GuardianContact { get; set; }
        public DateTime? LastCheckUpDate { get; set; }
    }
}

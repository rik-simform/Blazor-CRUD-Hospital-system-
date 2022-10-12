using HospitalSystem.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Server.Repositories
{
    public interface IPatientRepo
    {
        IEnumerable<Patient> GetAllPatients();
        void AddPatient(Patient patient);
        void UpdatePatient(Patient patient);
        Patient GetPatientById(long id);
        void DeletePatient(long id);
    }
}

using HospitalSystem.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Server.Repositories
{
    public interface IDoctorRepo
    {
        Task<IEnumerable<Doctor>> GetAllDoctors();
        void AddDoctor(Doctor doc);
        void UpdateDoctor(Doctor doc);
        Doctor GetDoctorById(long id);
        void DeleteDoctor(long id);
    }
}

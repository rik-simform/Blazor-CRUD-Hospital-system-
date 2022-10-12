using HospitalSystem.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Server.Repositories
{
    public interface INurseRepo
    {
        Task<IEnumerable<Nurse>> GetAllNurses();
        void AddNurse(Nurse nurse);
        void UpdateNurse(Nurse nurse);
        Nurse GetNurseById(long id);
        void DeleteNurse(long id);
    }
}

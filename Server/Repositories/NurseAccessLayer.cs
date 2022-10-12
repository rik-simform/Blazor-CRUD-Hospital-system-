using HospitalSystem.Server.Data;
using HospitalSystem.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Server.Repositories
{
    public class NurseAccessLayer : INurseRepo
    {
        private AppDbContext _context;
        public NurseAccessLayer(AppDbContext context)
        {
            _context = context;
        }
        public void AddNurse(Nurse nurse)
        {
            try
            {
                _context.Nurses.Add(nurse);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteNurse(long id)
        {
            try
            {
                Nurse nurse = _context.Nurses.Find(id);
                _context.Nurses.Remove(nurse);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<Nurse>> GetAllNurses()
        {
            try
            {
                return await _context.Nurses.ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Nurse GetNurseById(long id)
        {
            try
            {
                Nurse nurse = _context.Nurses.Find(id);

                return nurse;
            }
            catch
            {
                throw;
            }
        }

        public void UpdateNurse(Nurse nurse)
        {
            try
            {
                _context.Entry(nurse).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}

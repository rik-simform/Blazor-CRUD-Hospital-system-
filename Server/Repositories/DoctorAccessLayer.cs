using HospitalSystem.Server.Data;
using HospitalSystem.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Server.Repositories
{
    public class DoctorAccessLayer : IDoctorRepo
    {
        private AppDbContext _context;
        public DoctorAccessLayer(AppDbContext context)
        {
            _context = context;
        }

        //To Get all Doctors details   
        public async Task<IEnumerable<Doctor>> GetAllDoctors()
        {
            try
            {
                return await _context.Doctors.ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //To Add new Doctor record     
        public void AddDoctor(Doctor Doctor)
        {
            try
            {
                _context.Doctors.Add(Doctor);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Doctor    
        public void UpdateDoctor(Doctor Doctor)
        {
            try
            {
                _context.Entry(Doctor).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Doctor    
        public Doctor GetDoctorData(long id)
        {
            try
            {
                Doctor Doctor = _context.Doctors.Find(id);
                return Doctor;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Doctor    
        public void DeleteDoctor(long id)
        {
            try
            {
                Doctor emp = _context.Doctors.Find(id);
                _context.Doctors.Remove(emp);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Doctor GetDoctorById(long id)
        {
            try
            {
                Doctor Doctor = _context.Doctors.Find(id);
                return Doctor;
            }
            catch
            {
                throw;
            }
        }
    }
}

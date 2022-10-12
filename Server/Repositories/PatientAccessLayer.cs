using HospitalSystem.Server.Data;
using HospitalSystem.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Server.Repositories
{
    public class PatientAccessLayer : IPatientRepo
    {
        private AppDbContext _context;
        public PatientAccessLayer(AppDbContext context)
        {
            _context = context;
        }
        public void AddPatient(Patient patient)
        {
            try
            {
                _context.Patients.Add(patient);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeletePatient(long id)
        {
            try
            {
                Patient patient = _context.Patients.Find(id);
                _context.Patients.Remove(patient);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            try
            {
                return _context.Patients.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Patient GetPatientById(long id)
        {
            try
            {
                Patient patient = _context.Patients.Find(id);

                return patient;
            }
            catch
            {
                throw;
            }
        }

        public void UpdatePatient(Patient patient)
        {
            try
            {
                _context.Entry(patient).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}

using HospitalSystem.Server.Models;
using HospitalSystem.Server.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace HospitalSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private IPatientRepo _Patient;



        public PatientController(IPatientRepo PatientRepo)
        {
            _Patient = PatientRepo;
        }



        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return Ok(await _Patient.GetAllPatients());
        }



        [HttpPost]
        public void Create([FromBody] Patient Patient)
        {
            if (ModelState.IsValid)
                this._Patient.AddPatient(Patient);
        }



        [HttpGet("{id}")]
        public Patient Details(int id)
        {
            return _Patient.GetPatientById(id);
        }



        [HttpPut]
        public void Edit([FromBody] Patient Patient)
        {
            if (ModelState.IsValid)
                this._Patient.UpdatePatient(Patient);
        }



        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _Patient.DeletePatient(id);
        }
    }
}
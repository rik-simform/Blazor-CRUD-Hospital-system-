using HospitalSystem.Server.Models;
using HospitalSystem.Server.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles ="Doctor")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DoctorController : ControllerBase
    {
        private IDoctorRepo _doctor;

        public DoctorController(IDoctorRepo doctorRepo)
        {
            _doctor = doctorRepo;
        }

        [HttpGet]
        /*[Route("api/Doctor/Index")]*/
        
        public async Task<ActionResult> Index()
        {
            return Ok(await _doctor.GetAllDoctors());
        }

        [HttpPost]
       /* [Route("api/Doctor/Create")]*/
        public void Create([FromBody] Doctor doctor)
        {
            if (ModelState.IsValid)
                this._doctor.AddDoctor(doctor);
        }

        [HttpGet("{id}")]
      /*  [Route("api/Doctor/Details/{id}")]*/
        public Doctor Details(int id)
        {
            return _doctor.GetDoctorById(id);
        }

        [HttpPut]
       /* [Route("api/Doctor/Edit")]*/
        public void Edit([FromBody] Doctor doctor)
        {
            if (ModelState.IsValid)
                this._doctor.UpdateDoctor(doctor);
        }

        [HttpDelete("{id}")]
       /* [Route("api/Doctor/Delete/{id}")]*/
        public void Delete(int id)
        {
            _doctor.DeleteDoctor(id);
        }
    }
}

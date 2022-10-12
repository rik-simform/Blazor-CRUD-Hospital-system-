using HospitalSystem.Server.Models;
using HospitalSystem.Server.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace HospitalSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Doctor")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class NurseController : ControllerBase
    {
        private INurseRepo _Nurse;

        public NurseController(INurseRepo NurseRepo)
        {
            _Nurse = NurseRepo;
        }

        [HttpGet]
        [Route("api/Nurse/Index")]
        public async Task<IActionResult> Index()
        {
            return Ok(await _Nurse.GetAllNurses());
        }

        [HttpPost]
        [Route("api/Nurse/AddNurse")]
        public void Create([FromBody] Nurse Nurse)
        {
            if (ModelState.IsValid)
                this._Nurse.AddNurse(Nurse);
        }

        [HttpGet("{id}")]
        [Route("api/Nurse/AddNurse/{id}")]
        public Nurse Details(int id)
        {
            return _Nurse.GetNurseById(id);
        }

        [HttpPut]
        [Route("api/Nurse/EditNurse")]
        public void Edit([FromBody] Nurse Nurse)
        {
            if (ModelState.IsValid)
                this._Nurse.UpdateNurse(Nurse);
        }

        [HttpDelete("{id}")]
        [Route("api/Nurse/Delete/{id}")]
        public void Delete(int id)
        {
            _Nurse.DeleteNurse(id);
        }
    }
}

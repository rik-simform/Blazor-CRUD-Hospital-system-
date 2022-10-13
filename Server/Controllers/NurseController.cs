using HospitalSystem.Server.Models;
using HospitalSystem.Server.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;



namespace HospitalSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Doctor, Nurse")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class NurseController : ControllerBase
    {
        private INurseRepo _Nurse;



        public NurseController(INurseRepo NurseRepo)
        {
            _Nurse = NurseRepo;
        }



        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _Nurse.GetAllNurses());
        }



        [HttpPost]
        public void Create([FromBody] Nurse Nurse)
        {
            if (ModelState.IsValid)
                this._Nurse.AddNurse(Nurse);
        }



        [HttpGet("{id}")]
        public Nurse Details(int id)
        {
            return _Nurse.GetNurseById(id);
        }



        [HttpPut]
        public void Edit([FromBody] Nurse Nurse)
        {
            if (ModelState.IsValid)
                this._Nurse.UpdateNurse(Nurse);
        }



        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _Nurse.DeleteNurse(id);
        }
    }
}
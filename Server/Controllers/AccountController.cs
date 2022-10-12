
using HospitalSystem.Server.Authentication;
using HospitalSystem.Shared;
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
    public class AccountController : ControllerBase
    {
        private readonly UserAcountService _userAcountService;

        public AccountController(UserAcountService userAcountService)
        {
            _userAcountService = userAcountService;
        }
        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest)
        {
            var jwtAuthManager = new JwtAuthenticationManager(_userAcountService);
            var userSession = jwtAuthManager.GenerateJwtToken(loginRequest.Username, loginRequest.Password);
            if(userSession is null)
            {
                return Unauthorized();
            }
            else
            {
                return userSession;
            }

        }
    }
}

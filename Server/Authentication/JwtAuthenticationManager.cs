
using HospitalSystem.Shared;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Server.Authentication
{
    public class JwtAuthenticationManager
    {
        public const string JWT_SECURITY_KEY = "0876b2f2687da5bcfe6e4dd46722027a";
        private const int JWT_TOKEN_VALIDITY_MINS = 20;

        private readonly UserAcountService _userAccountService;
        public JwtAuthenticationManager(UserAcountService userAcountService)
        {
            _userAccountService = userAcountService;
        }

        public UserSession? GenerateJwtToken(string username, string paswword)
        {
            if(string.IsNullOrWhiteSpace(username)|| string.IsNullOrWhiteSpace(paswword))
            {
                return null;
            }

            // Validating User Credentials

            var user = _userAccountService.GetUserAccountByUserName(username);
            if(user == null || user.Password !=paswword)
            {
                return null;
            }
            // Generating JWT Token.

            var tokenExpiryTimeStamp = DateTime.Now.AddMinutes(JWT_TOKEN_VALIDITY_MINS);
            var tokenKey = Encoding.ASCII.GetBytes(JWT_SECURITY_KEY);
            var claimsIdentity = new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
            });

            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature);

            var signingTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claimsIdentity,
                Expires = tokenExpiryTimeStamp,
                SigningCredentials = signingCredentials
            };
            var jwtSecurityTokenhandler = new JwtSecurityTokenHandler();
            var securityToken = jwtSecurityTokenhandler.CreateToken(signingTokenDescriptor);
            var token = jwtSecurityTokenhandler.WriteToken(securityToken);

            // Returing the UserSession Model
            var userSession = new UserSession
            {
                Username = user.Username,
                Role = user.Role,
                Token = token,
                ExpiresIn = (int)tokenExpiryTimeStamp.Subtract(DateTime.Now).TotalSeconds
            };
            return userSession;
        }

    }
}

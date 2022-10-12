using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalSystem.Shared
{
   public class UserSession
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        public int ExpiresIn { get; set; }
        public DateTime ExpiryTimeStamp { get; set; }
    }
}

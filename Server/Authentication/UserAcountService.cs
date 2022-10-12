using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Server.Authentication
{
    public class UserAcountService
    {
        private List<UserAccount> _userAccountList;

        public UserAcountService()
        {
            _userAccountList = new List<UserAccount>
            {
                new UserAccount{Username="Doctor@email.com", Password="Doctor123" , Role="Doctor"},
                new UserAccount {Username="Nurse@email.com", Password="Nurse123",Role="Nurse"},
                new UserAccount{Username="Patient1@email.com", Password="Patient1" , Role="Patient"}
            };
        }

        public UserAccount? GetUserAccountByUserName(string username)
        {
            return _userAccountList.FirstOrDefault(x => x.Username == username);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLogin.Model
{
    public class UserRecord
    {
        public string UserName { get;  }
        public string LoginId { get; }
        public string Password { get; }
        public bool IsLogined { get; set; } = false;

        public UserRecord(string userName, string loginId, string password)
        {
            UserName = userName;
            LoginId = loginId;
            Password = password;
        }
    }
}

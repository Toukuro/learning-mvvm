using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace WpfLogin.Model
{
    public class UserModel
    {
        private List<UserRecord> userList;

        public UserModel()
        {
            userList = new List<UserRecord>
            {
                new UserRecord("梅田 太郎", "t_umeda", "umeda"),
                new UserRecord("淀屋橋 一郎", "i_yodoyabashi", "yodoyabashi"),
                new UserRecord("本町 次郎", "j_honmachi", "honmachi"),
            };
        }

        public bool Authenticate(string loginId, string password)
        {
            return userList
                .Any(user => user.LoginId == loginId && user.Password == password);
        }

        public bool IsLogined(string loginId)
        {
            return userList
                .Any(user => user.LoginId == loginId && user.IsLogined);
        }
    }
}

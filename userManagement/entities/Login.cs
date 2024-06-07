using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace userManagement
{
    public class Login
    {
        private String username;
        private String password;

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
        public override string ToString()
        {
            return $"Username: {Username}, Password: {Password}";
        }

    }
}

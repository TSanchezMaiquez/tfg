using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userManagement
{
    public class Users
    {

        private string username;
        private string password;
        private string secondname;
        private string email;
        private UserRol userRol;
        private double salary;
        private List<String> contacts;
        private long numIdent;
        private byte[] imagen;

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

        public string Secondname
        {
            get => secondname;
            set => secondname = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public UserRol UserRol
        {
            get => userRol;
            set => userRol = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }
        public List<string> Contacts { get => contacts; set => contacts = value; }
        public long NumIdent { get => numIdent; set => numIdent = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }

        public override string ToString()
        {
            return $"Username: {Username}, Password: {Password}, Secondname: {Secondname}, Email: {Email}, UserRol: {UserRol}, Salary: {Salary}";
        }
    }


    public enum UserRol
    {
        ADMIN, WORKER
    }
}

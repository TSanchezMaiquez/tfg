using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userManagement.users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace userManagement
{
    public partial class Inicio : Form
    {
        private AuthenticationManager authenticationManager= new AuthenticationManager();
        private AuthService authService = new AuthService(); // O cualquier método para obtener una instancia válida de AuthService
        private UsersManager usersManager;

        public Inicio()
        {
            InitializeComponent();
            usersManager = new UsersManager(authService);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users
            {
                Username = "ejemploUsuario2",
                Password = "contraseña123",
                Secondname = "Apellido Ejemplo",
                Email = "usuario@example.com",
                UserRol = UserRol.ADMIN, 
                Salary = 50000 
            };
            await authenticationManager.RegisterAsync(user);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login
            {
                Username = "ejemploUsuario2",
                Password = "contraseña123"
            };
            await authenticationManager.LoginAsync(login);
        }

        private async void button3_Click(object sender, EventArgs e)
        {

            Users user =  await usersManager.GetUserAsync("ejemploUsuario2");
            MessageBox.Show(user.ToString());
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            String username = "ejemploUsuario2";
            await usersManager.DeleteUserAsync(username);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            Users user = new Users
            {
                Username = "ejemploUsuario2",
                Password = "contraseña123",
                Secondname = "ASanchezzzzzzzzzzzzz",
                Email = "usuario@example.com",
                UserRol = UserRol.ADMIN,
                Salary = 50000
            };
            user = await usersManager.UpdateUserAsync(user);
            MessageBox.Show(user.ToString());
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string filter = "username:MATCH:un,secondname:MATCH:an";
            List<Users> user = await usersManager.GetUsersByCriteriaAsync(filter);
            MessageBox.Show(user.Count+"");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using userManagement.users;
using userManagement.validations;

namespace userManagement
{
    public partial class Admin : Form
    {
        private AuthService authService = new AuthService();
        private UsersManager usersManager;
        private Validations validation = new Validations();
        private List<Users> users = new List<Users>();
        private Users user = new Users();
        public Admin()
        {
            InitializeComponent();
            usersManager = new UsersManager(authService);
            allUsers();
        }
        private async void allUsers()
        {
            string filter = filtersBuilder();
            dgvAllUsers.Rows.Clear();
            dgvAllUsers.Columns.Clear();

            users = await usersManager.GetUsersByCriteriaAsync(filter);

            dgvAllUsers.Columns.Add("Username", "Username");
            dgvAllUsers.Columns.Add("SecondName", "Second Name");
            dgvAllUsers.Columns.Add("Email", "Email");
            dgvAllUsers.Columns.Add("UserRol", "UserRol");
            dgvAllUsers.Columns.Add("Salary", "Salary");

            foreach (Users user in users)
            {
                dgvAllUsers.Rows.Add(user.Username, user.Secondname, user.Email, user.UserRol, user.Salary);

            }
        }
        private string filtersBuilder()
        {
            bool SalarioValido = validation.validateDouble(FSalary.Text);


            List<String> filters = new List<String>();
            if (FUsername.Text.Length > 0)
            {
                filters.Add("username:MATCH:" + FUsername.Text);
            }
            if (FSecondname.Text.Length > 0)
            {
                filters.Add("secondname:MATCH:" + FSecondname.Text);
            }
            if (FEmail.Text.Length > 0)
            {
                filters.Add("email:MATCH:" + FEmail.Text);
            }
            if (FUserRol.Text.Length > 0)
            {
                filters.Add("userRol:MATCH:" + FUserRol.Text);
            }
            if (FSalary.Text.Length > 0 && SalarioValido)
            {
                double salary = double.Parse(FSalary.Text);
                string ccbSalary = cbbSalary.SelectedItem.ToString();
                if (ccbSalary.Equals("<"))
                {
                    filters.Add("salary:LESS_THAN:" + salary);
                }
                else if (ccbSalary.Equals(">"))
                {
                    filters.Add("salary:GREATER_THAN:" + salary);
                } else if (ccbSalary.Equals("="))
                {
                    filters.Add("salary:EQUAL:" + salary);
                }
            }
            if (filters.Count > 0)
            {
                return string.Join(",", filters);
            }
            else
            {
                return string.Empty;
            }
        }
        private void filtrar(object sender, EventArgs e)
        {
            allUsers();
        }
        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarCamposDeTextoAnadeEditar();
            grb2.Visible = true;
            grb2.Text = "Añadir usuario";
            txtPassword.Enabled = true;
            grbEditar.Visible = false;
            btnEditar.Visible = false;
            btnAnadir.Visible = true;
            grbEliminar.Visible = false;
        }
        private void limpiarCamposDeTextoAnadeEditar()
        {
            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtSecondname.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            FUsername.Text = String.Empty;
            FSecondname.Text = String.Empty;
            FEmail.Text = String.Empty;
            FUserRol.Text = String.Empty;
            FSalary.Text = String.Empty;
            cbbSalary.Text = String.Empty;
        }

        private async void btbAnadir_Click(object sender, EventArgs e)
        {          
            if (validateRegisterFields() && cbbUserRol.SelectedItem != null)
            {
                string selectedUserRol = cbbUserRol.SelectedItem.ToString();
                UserRol userRol;
                Enum.TryParse(selectedUserRol, out userRol);
                double salary = double.Parse(txtSalary.Text);

                Users user = new Users
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Secondname = txtSecondname.Text,
                    Email = txtEmail.Text,
                    UserRol = userRol,
                    Salary = salary
                };
                await authService.RegisterAsync(user);
                allUsers();
            }else
            {
                MessageBox.Show("Rellena los campos en blanco");
            }

        }
        private bool validateRegisterFields()
        {
            bool username = handleValidationResult(validation.validateName(txtUsername.Text), txtUsername);
            bool password = handleValidationResult(validation.validatePassword(txtPassword.Text), txtPassword);
            bool secondname = handleValidationResult(validation.validateName(txtSecondname.Text), txtSecondname);
            bool email = handleValidationResult(validation.validateEmail(txtEmail.Text), txtEmail);          
            bool salary = handleValidationResult(validation.validateDouble(txtSalary.Text), txtSalary);

            return username && password && secondname & email && salary;

        }
        private bool handleValidationResult(bool isValid, TextBox textBox)
        {
            if (!isValid)
            {
                handleInvalidField(textBox);
                return false;
            }
            return true;
        }
        private void handleInvalidField(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = string.Empty;
        }
        private void btnAnadirCerrar_Click(object sender, EventArgs e)
        {
            grb2.Visible = false;
        }
        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditarUsername.Text = string.Empty;
            grb2.Visible = false;
            grbEditar.Visible = true;
            grbEliminar.Visible = false;
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grbEditar.Visible = false;
        }
        private async void buscar_Click(object sender, EventArgs e)
        {
            if (users.Any(userToFind => userToFind.Username == txtEditarUsername.Text))
            {
                user = await usersManager.GetUserAsync(txtEditarUsername.Text);

                grbEditar.Visible = false;
                btnAnadir.Visible = false;
                btnEditar.Visible = true;

                txtUsername.Text = user.Username;
                txtPassword.Enabled = false;
                txtSecondname.Text = user.Secondname;
                txtEmail.Text = user.Email;
                txtSalary.Text = user.Salary.ToString();

                if (user.UserRol == UserRol.ADMIN)
                {
                    cbbUserRol.SelectedItem = "ADMIN";
                }
                else if (user.UserRol == UserRol.WORKER)
                {
                    cbbUserRol.SelectedItem = "WORKER";
                }
                grb2.Text = "Editar usuario";
                grb2.Visible = true;
            }
            else
            {
                MessageBox.Show("El usuario no existe");
                txtEditarUsername.Text = string.Empty;
            }          
        }
        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grb2.Visible=false;
            grbEditar.Visible=false;
            grbEliminar.Visible=true;
        }

        private void btbCerrarElimnar_Click(object sender, EventArgs e)
        {
            grbEliminar.Visible = false;
        }
        private async void btnElimnar_Click(object sender, EventArgs e)
        {
            await usersManager.DeleteUserAsync(txtUsernameElimnar.Text);
            allUsers();
            grbEliminar.Visible = false;
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (validateUpdateFields())
            {
                string selectedUserRol = cbbUserRol.SelectedItem.ToString();
                UserRol userRol;
                Enum.TryParse(selectedUserRol, out userRol);
                double salary = double.Parse(txtSalary.Text);

                Users user = new Users
                {
                    Username = txtUsername.Text,
                    Password = this.user.Password,
                    Secondname = txtSecondname.Text,
                    Email = txtEmail.Text,
                    UserRol = userRol,
                    Salary = salary
                };
                await usersManager.UpdateUserAsync(user);
                allUsers();
                grb2.Visible=false;
            }
            else
            {
                MessageBox.Show("Rellena los campos en blanco");
            }

        }
        private bool validateUpdateFields()
        {
            bool username = handleValidationResult(validation.validateName(txtUsername.Text), txtUsername);
            bool secondname = handleValidationResult(validation.validateName(txtSecondname.Text), txtSecondname);
            bool email = handleValidationResult(validation.validateEmail(txtEmail.Text), txtEmail);
            bool salary = handleValidationResult(validation.validateDouble(txtSalary.Text), txtSalary);

            return username && secondname & email && salary;

        }

        private void btnLimpiarAnadir_Click(object sender, EventArgs e)
        {
            limpiarCamposDeTextoAnadeEditar();
        }

       
    }
}



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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace userManagement
{
    public partial class FormInicio : Form
    {
        private AuthenticationManager authenticationManager = new AuthenticationManager();
        private AuthService authService = new AuthService();
        private UsersManager usersManager;
        private Validations validation = new Validations();
        public FormInicio()
        {
            InitializeComponent();
            clearFields();
            usersManager = new UsersManager(authService);
        }
        private void clearFields()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRUsername.Text = string.Empty;   
            txtRPassword.Text = string.Empty;
            txtRSecondname.Text = string.Empty;
            txtREmail.Text = string.Empty;
            txtRSueldo.Text = string.Empty;
           
        }
        private async void buttonLogin(object sender, EventArgs e)
        {
            bool username = validation.validateName(txtUsername.Text);
            bool password = validation.validatePassword(txtPassword.Text);
            if (username && password)
            {
                Login login = new Login
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };
                bool response = await authenticationManager.LoginAsync(login);
                if (response)
                {
                    clearFields();
                    this.Hide();
                    Admin admin = new Admin();
                    admin.FormClosed += (s, args) => this.Show();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Datos no validos");
                    clearFields();
                }
            }
            else
            {
                handleInvalidField(txtUsername);
                handleInvalidField(txtPassword);
               
                MessageBox.Show("Datos no valido");
            }
        }
        private void buttonRegisterInLogin(object sender, EventArgs e)
        {
            clearFields();
            pnlLogin.Visible = false;
            pnlLoginFondo.Visible = false;
            pnlRegistro.Visible = true;
            pnlRegistroFondo.Visible = true;
        }
        private void BtnRegisterBack(object sender, EventArgs e)
        {
            backToLogin();
        }
        private void backToLogin()
        {
            clearFields();
            pnlLogin.Visible = true;
            pnlLoginFondo.Visible = true;
            pnlRegistro.Visible = false;
            pnlRegistroFondo.Visible = false;
        }
        private async void buttonRegister(object sender, EventArgs e)
        {
            if (validateRegisterFields())
            {
                Users user = new Users
                {
                    Username = txtRUsername.Text,
                    Password = txtRPassword.Text,
                    Secondname = txtRSecondname.Text,
                    Email = txtREmail.Text,
                    UserRol = UserRol.ADMIN,
                    Salary = double.Parse(txtRSueldo.Text),
                };
                await authService.RegisterAsync(user);
                MessageBox.Show("Volviendo a la pagina principal");
                backToLogin();
            }else
            {
                MessageBox.Show("Rellene los campos en blanco");
            }             
        }
        private bool validateRegisterFields()
        {
            bool username = handleValidationResult(validation.validateName(txtRUsername.Text), txtRUsername);
            bool password = handleValidationResult(validation.validatePassword(txtRPassword.Text), txtRPassword);
            bool secondname = handleValidationResult(validation.validateName(txtRSecondname.Text), txtRSecondname);
            bool email = handleValidationResult(validation.validateEmail(txtREmail.Text), txtREmail);
            bool salario =handleValidationResult(validation.validateDouble(txtRSueldo.Text), txtRSueldo);

            return username && password && secondname && email && salario;

        }
        private bool handleValidationResult(bool isValid, System.Windows.Forms.TextBox textBox)
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
     
    }
}

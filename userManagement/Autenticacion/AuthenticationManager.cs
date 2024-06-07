using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userManagement
{
    public class AuthenticationManager
    {
        private readonly AuthService authService;

        public AuthenticationManager()
        {
            authService = new AuthService();
        }

        public async Task<bool> LoginAsync(Login credentials)
        {
            try
            {              
                string token = await authService.LoginAsync(credentials);             
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task RegisterAsync(Users user)
        {       
            try
            {
                string token = await authService.RegisterAsync(user);           
        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el registro: " + ex.Message);
                throw;
            }
        }
    }
}
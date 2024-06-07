using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userManagement.users
{
    public class UsersManager
    {
        private UsersService usersService;
        public UsersManager(AuthService authService)
        {
            this.usersService = new UsersService(authService);
        }

        public async Task<Users> GetUserAsync(string username)
        {
            try
            {
                return await usersService.GetUserAsync(username);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario: " + ex.Message);
            }
        }

        public async Task DeleteUserAsync(string username)
        {
            try
            {
                await usersService.DeleteUserAsync(username);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario: " + ex.Message);
            }
        }
        public async Task<Users> UpdateUserAsync( Users updatedUser)
        {       
            try
            {
                return await usersService.UpdateUserAsync(updatedUser.Username, updatedUser);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el usuario: " + ex.Message);
            }
        }
        public async Task<List<Users>> GetUsersByCriteriaAsync(string filter)
        {
            try
            {
                return await usersService.GetUsersByCriteriaAsync(filter);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los usuarios: " + ex.Message);
            }
        }
    }
}
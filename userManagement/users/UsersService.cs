using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Security;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Net;

namespace userManagement.users
{
    public class UsersService
    {
        private readonly string baseUrl = "http://localhost:8080/users";
        private readonly AuthService authService;
        public UsersService(AuthService authService)
        {
            this.authService = authService;
        }

        public async Task<Users> GetUserAsync(string username)
        {
            string obtenerUsuarioUrl = $"{baseUrl}/users/{username}";


            using (HttpClient client = new HttpClient())
            {
                string token = authService.GetToken();

                if (token != null)
                {                    
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                HttpResponseMessage response = await client.GetAsync(obtenerUsuarioUrl);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Users>(responseBody);
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {               
                    return new Users();
                }
                else
                {
                    throw new Exception($"Error al obtener el usuario: {response.StatusCode}");
                }

            }
        }
        public async Task DeleteUserAsync(string username)
        {
            string deleteUserUrl = $"{baseUrl}/users/{username}";

            using (HttpClient client = new HttpClient())
            {
                string token = authService.GetToken();

                if (token != null)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                HttpResponseMessage response = await client.DeleteAsync(deleteUserUrl);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Usuario '{username}' eliminado correctamente.");
                }
                else
                {
                    throw new Exception($"Error al eliminar el usuario '{username}'. " +
                        $"Código de estado: {response.StatusCode}");
                }
            }
        }

        public async Task<Users> UpdateUserAsync(string username, Users updatedUser)
        {
            string updateUserUrl = $"{baseUrl}/users/{username}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string token = authService.GetToken();

                    if (token != null)
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    }
                    var response = await client.PatchAsJsonAsync(updateUserUrl, updatedUser);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Modificacion realizada");
                    return JsonConvert.DeserializeObject<Users>(responseBody);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el usuario: " + ex.Message);
            }
        }
        public async Task<List<Users>> GetUsersByCriteriaAsync(string filter)
        {
            string getUsersUrl = $"{baseUrl}/users";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string token = authService.GetToken();
                    if (token != null)
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    }
                    if (!string.IsNullOrEmpty(filter))
                    {
                        getUsersUrl += $"?filter={filter}";
                    }
                    HttpResponseMessage response = await client.GetAsync(getUsersUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Users>>(responseBody);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener usuarios por criterio: " + ex.Message);
            }
        }
    }
}


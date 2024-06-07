using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userManagement
{
    public class AuthService
    {
        private readonly string baseUrl = "http://localhost:8080/users";
        private readonly HttpClient httpClient;
        private string tokenFilePath = "token.txt";
        public AuthService()
        {
            httpClient = new HttpClient();
        }

        public async Task<string> RegisterAsync(Users user)
        {
            string registerUrl = $"{baseUrl}/auth/register";
            var response = await httpClient.PostAsJsonAsync(registerUrl, user);
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                string token = await response.Content.ReadAsStringAsync();
                SaveToken(token);
                MessageBox.Show("Registro realizado");
                return token;
            }
            else
            {
                throw new Exception($"El registro falló. Código de estado: {response.StatusCode}");
            }
        }

        public async Task<string> LoginAsync(Login credentials)
        {
            string loginUrl = $"{baseUrl}/auth/login";

            var response = await httpClient.PostAsJsonAsync(loginUrl, credentials);
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                string token = await response.Content.ReadAsStringAsync();
                SaveToken(token);
                return token;
            }
            else
            {
                throw new Exception($"La autenticación falló. Código de estado: {response.StatusCode}");
            }
        }

        public void SaveToken(string tokenValue)
        {
            int startIndex = tokenValue.IndexOf(':')+2;
            int endIndex = tokenValue.LastIndexOf('"');
            string cleanedTokenValue = tokenValue.Substring(startIndex, endIndex - startIndex);
            File.WriteAllText(tokenFilePath, cleanedTokenValue);
            Console.WriteLine("Token guardado correctamente en el archivo: " + tokenFilePath);
        }
    
        public String GetToken()
        {
            if (File.Exists(tokenFilePath))
            {
                string token = File.ReadAllText(tokenFilePath);
                Console.WriteLine("Token leído correctamente desde el archivo: " + tokenFilePath);
                return token;
            }
            else
            {
                Console.WriteLine("No se encontró el archivo de token: " + tokenFilePath);
                return null;
            }
        }
    }
}

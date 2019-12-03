using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Store.Application.Models;

namespace Store.Application.Services
{
    public class UserService : IUserService
    {
        public async Task<string> LoginAsync(UserViewModel userViewModel)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.PostAsJsonAsync("http://localhost:10479/api/v1/users/login", userViewModel);

            var user = await response.Content.ReadAsAsync<UserViewModel>();

            return user.Token;
        }

       
    }
}

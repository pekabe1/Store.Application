using Microsoft.AspNetCore.Mvc;
using Store.Application.Models;
using Store.Application.Services;
using System.Threading.Tasks;

namespace Store.Application.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;

        public IActionResult Login()
        {
            return View();
        }
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserViewModel user)
        {
            var token = await userService.LoginAsync(user);
            return RedirectToAction(nameof(Login));
        }
    }
}
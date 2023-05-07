using dotnet_project.Models.DTO;
using dotnet_project.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_project.Controllers
{
    public class UserAuthenticationController : Controller
    {
        
        private IUserAuthenticationService authService;
        public UserAuthenticationController(IUserAuthenticationService authService)
        {
            this.authService = authService;
        }
        

        public async Task<IActionResult> Registerview()
        {
            return View(); }
        public async Task<IActionResult> Register(RegistrationModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await authService.RegisterAsync(model);
            if (result.StatusCode == 1)
                return RedirectToAction("Index", "Home");
            else
            {
                TempData["msg"] = "Could not Register in..";
                return RedirectToAction(nameof(Register));
            }
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await authService.LoginAsync(model);
            if (result.StatusCode == 1)
                return RedirectToAction("Index", "Home");
            else
            {
                TempData["msg"] = "Could not logged in..";
                return RedirectToAction(nameof(Login));
            }
        }

        public async Task<IActionResult> Logout()
        {
            await authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }

    }
}

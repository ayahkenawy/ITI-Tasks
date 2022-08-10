using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcAuth.Data.Models;
using MvcAuth.ViewModels;
using System.Security.Claims;

namespace MvcAuth.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManger;
        private readonly SignInManager<User> _signInManager;

        public UserController(UserManager<User> userManger, SignInManager<User> signInManager)
        {
            _userManger = userManger;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            var user = new User
            {
                UserName = registerVM.UserName,
                ExtrInfo = registerVM.ExtraInfo
            };
            var result = await _userManger.CreateAsync(user, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return View(registerVM);
            }
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            var user = await _userManger.FindByNameAsync(loginVM.UserName);
            bool isAuth = await _userManger.CheckPasswordAsync(user, loginVM.Password);

            if (!isAuth)
            {
                ModelState.AddModelError("Login", "Credential are not correct");
                return View(loginVM);
            }

            var claims = new List<Claim>
        {
            new Claim (ClaimTypes.Role, "Admin"),
            new Claim ("Nationality", "EG"),
        };

            await _signInManager.SignInWithClaimsAsync(user, true, claims);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
}

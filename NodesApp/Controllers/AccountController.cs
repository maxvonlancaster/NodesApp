using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL.Entities;
using NodesApp.Models.AccountModels;
using System.Security.Claims;

namespace NodesApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            User user = _userService.GetByUserName(User.Identity.Name);
            EditAccountModel model = new EditAccountModel()
            {
                Password = user.Password,
                Email = user.Email,
                //TelegramId = user.TelegramId
            };
            return View((object)model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _userService.GetByCredentials(model.UserName, model.Password);
                if (user != null)
                {
                    Authenticate(user.UserName);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Incorrect credentials");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _userService.GetByUserName(model.UserName);
                if (user == null)
                {
                    User newUser = new User()
                    {
                        UserName = model.UserName,
                        Password = model.Password,
                        Email = model.Email,
                        //TelegramId = model.TelegramId
                    };

                    _userService.Add(newUser);

                    Authenticate(model.UserName);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect credentials");
                }
            }

            return View(model);
        }


        private void Authenticate(string userName)
        {
            // create one claim 
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // create object ClaimsIdentity 
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // install of auth-n cookies 
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Edit(EditAccountModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _userService.GetByUserName(User.Identity.Name);
                user.Email = model.Email;
                user.Password = model.Password;
                //user.TelegramId = model.TelegramId;
                _userService.Update(new List<User>() { user });
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Incorrect credentials");
            return View(model);
        }


    }
}

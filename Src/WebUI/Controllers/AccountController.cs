using Discussor.Infrastructure.Contracts;
using Discussor.Infrastructure.Identity;
using Discussor.WebUI.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Discussor.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSende)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSende;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.Login };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);
                    //await _emailSender.SendEmailAsync(user.Email, "Account Confirmation", "<p>Confirm your account</p><br />  " + confirmationLink);
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                } else
                {
                    foreach (var error in result.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(model.Login, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");
                else
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
            }

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
                return RedirectToAction("Index", "Home");

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);

            return RedirectToAction("Index", "Home");
        }

        //public async Task<IActionResult> ResendEmail()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        //    var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);
        //    await _emailSender.SendEmailAsync(user.Email, "Account Confirmation", "<p>Confirm your account</p><br />  " + confirmationLink);
        //    return RedirectToAction("Index", "Home");
        //}
    }
}

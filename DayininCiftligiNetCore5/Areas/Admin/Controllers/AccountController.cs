using DayininCiftligiNetCore5.Areas.Admin.Models;
using DayininCiftligiNetCore5.EmailServices;
using DayininCiftligiNetCore5.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AutoValidateAntiforgeryToken] //for csrf
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string ReturnUrl=null)
        {
            return View(new LoginModel() 
            {
                ReturnUrl = ReturnUrl
            });
        }

        [HttpPost]
        /*[ValidateAntiForgeryToken]*/ // for csrf
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if(user == null)
            {
                ModelState.AddModelError("Email", "Girdiğiniz epostaya ait bir kayıt bulunamadı.");
                return View(model);
            }

            if(!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("Email", "Girdiğiniz eposta onaylanmamış. Lütfen size gelen eposta ile hesabınızı onaylayınız");
                return View(model);
            }

            //3. parametre tarayıcı kapandığı anda cookie nin silinip silinmemesi (true = cookieyi silme)
            //4. parametre giriş denemesi engeli, (true = açık)
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);

            if(!result.Succeeded)
            {
                ModelState.AddModelError("Password", "Girilen parola hatalı. Lütfen tekrar deneyiniz.");
                return View(model);
            }

            return Redirect(model.ReturnUrl ?? "/Admin");

        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            CreateMessage("Başarılı bir şekilde çıkış yaptınız.", "success");
            return Redirect("/Login");
        }

        //[Authorize(Roles = "private")]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //[Authorize(Roles = "private")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if(result.Succeeded)
            {
                // generate token
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", new { 
                    userId = user.Id,
                    token = token
                });
                // sent email
                await _emailSender.SendEmailAsync(model.Email, "Hesabınızı Onaylayınız", $"Eposta hesabınızı onaylamak için lütfen aşağıdaki bağlantıya tıklayınız.<br> <a href='https://localhost:44385{url}'>Eposta Onay Bağlantısı</a>");

                //CreateMessage("Başarılı bir şekilde kayıt oldunuz. Lütfen giriş yapınız.", "success");
                return RedirectToAction("Login");
            }
            //View de password kısmına hata gönderme
            //ModelState.AddModelError("Password", "Error error");
            return View(model);
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if(userId == null || token == null)
            {
                CreateMessage("Geçersiz istekte bulundunuz.", "danger");
                return Redirect("/Login");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if(user==null)
            {
                CreateMessage("Hasap onaylama işlemi başarısız oldu.", "danger");
                return Redirect("/Login");
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);

            if(!result.Succeeded)
            {
                CreateMessage("Eposta onay işlemi başarısız oldu.", "danger");
                return Redirect("/Login");
            }
            
            CreateMessage("Hesabınız başarılı bir şekilde onaylandı.", "success");
            return Redirect("/Login");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if(string.IsNullOrEmpty(Email))
            {
                CreateMessage("Lütfen bir eposta adresi yazınız.", "danger");
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);
            if(user==null)
            {
                CreateMessage("Girdiğiniz epostaya ait hesap bulunmamaktadır. Lütfen kontrol edip tekrar deneyiniz.", "danger");
                return View();
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", new
            {
                userId = user.Id,
                token = token
            });
            // sent email
            await _emailSender.SendEmailAsync(Email, "Parola Sıfırlama", $"Parolanızı sıfırlamak için lütfen aşağıdaki bağlantıya tıklayınız.<br> <a href='https://localhost:44385{url}'>Parola Sıfırlama Bağlantısı</a>");
            
            CreateMessage("Parola sıfırlama bağlantısı eposta adresinize gönderildi.", "success");
            return View();
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            if(userId == null || token == null)
            {
                CreateMessage("Hatalı bir istekte bulundunuz.", "danger");
                return Redirect("/Login");
            }
            //user var mı kontrolü gerekli mi?
            var model = new ResetPasswordModel { Token = token };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if(!ModelState.IsValid)
            {
                CreateMessage("Hatalı bilgi. Lütfen kontrol edip tekrar deneyiniz.", "danger");
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user == null)
            {
                CreateMessage("Girilen epostaya ait bir kayıt bulunamadı.", "danger");
                return View(model);
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

            if(!result.Succeeded)
            {
                CreateMessage("Parola sıfırlama sırasında bir hata oluştu. Lütfen tekrar deneyiniz.", "danger");
                return View(model);
            }

            CreateMessage("Parolanız başarı ile yenilendi. Sisteme giriş yapabilirsiniz.", "success");
            return Redirect("/Login");
        }

        private void CreateMessage(string message, string alerttype)
        {
            var msg = new AlertMessageAdmin()
            {
                Message = message,
                AlertType = alerttype
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
        }
    }
}

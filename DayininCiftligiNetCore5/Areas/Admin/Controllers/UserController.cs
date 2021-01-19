using DayininCiftligiNetCore5.Areas.Admin.Models;
using DayininCiftligiNetCore5.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            if(!User.Identity.IsAuthenticated)
            {
                return Redirect("/Login");
            }
            var model = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.PageId = 99;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var entity = await _userManager.FindByNameAsync(User.Identity.Name);

            if (entity == null)
            {
                return NotFound();
            }

            ViewBag.PageId = 99;
            return View(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User model, IFormFile fileImage)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = _userManager.FindByIdAsync(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            var user = new User()
            { 
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            if (fileImage != null)
            {
                var deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\products", user.ProfilePhoto);

                var extension = Path.GetExtension(fileImage.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                user.ProfilePhoto = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\admin\\users\\pp", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileImage.CopyToAsync(stream);
                }

                if (System.IO.File.Exists(deletePath))
                {
                    System.IO.File.Delete(deletePath);
                }
            }
            //else
            //{
            //    entity.ImageUrl = model.ImageUrl;
            //}


            await _userManager.UpdateAsync(user);

            CreateMessage($"Ayarlarınız başarı ile kaydedildi.", "success");

            ViewBag.PageId = 99;
            return Redirect("/Admin/User/Edit");
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

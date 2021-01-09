using DayininCiftligiNetCore5.Areas.Admin.Models;
using DayininCiftligiNetCore5.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AutoValidateAntiforgeryToken] //for
    public class WebsiteDataController : Controller
    {
        private readonly IWebsiteDataRepository _websiteDataRepository;
        private readonly ISocialMediaRepository _socialMediaRepository;
        public WebsiteDataController(IWebsiteDataRepository websiteDataRepository, ISocialMediaRepository socialMediaRepository)
        {
            _websiteDataRepository = websiteDataRepository;
            _socialMediaRepository = socialMediaRepository;
        }

        public IActionResult Index()
        {
            var model = _websiteDataRepository.GetWebsiteData();
            ViewBag.PageId = 1;
            return View(model);
        }

        [IgnoreAntiforgeryToken] //why need this?
        [HttpPost]
        public async Task<IActionResult> LogosEdit(WebsitedataModel model, IFormFile fileFavicon, IFormFile fileLogo)
        {
            if (!ModelState.IsValid)
            {
                CreateMessage("Beklenmeyen bir hata oluştu.", "warning");
                return Redirect("/Admin/WebsiteData/Index");
            }
            var entity = _websiteDataRepository.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            if (fileFavicon != null)
            {
                var extension = Path.GetExtension(fileFavicon.FileName);
                //Datetime.Now.Ticks yerine Guid.NewGuid() de olabilir, benzersiz uzun bir string
                var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                entity.Favicon = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\logos", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileFavicon.CopyToAsync(stream);
                }
            }

            if (fileLogo != null)
            {
                var extension = Path.GetExtension(fileLogo.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                entity.Logo = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\logos", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileLogo.CopyToAsync(stream);
                }
            }

            //entity.Favicon = model.Favicon;
            //entity.Logo = model.Logo;

            _websiteDataRepository.Update(entity);

            CreateMessage("Değişiklikler başarılı bir şekilde kaydedildi.", "success");
            return Redirect("/Admin/WebsiteData/Index");
        }

        [IgnoreAntiforgeryToken] //why need this?
        [HttpPost]
        public IActionResult MetaDataEdit(WebsitedataModel model)
        {
            if (!ModelState.IsValid)
            {
                CreateMessage("Beklenmeyen bir hata oluştu.", "warning");
                return Redirect("/Admin/WebsiteData/Index");
            }
            var entity = _websiteDataRepository.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.CopyrightForMeta = model.CopyrightForMeta;
            entity.Author = model.Author;
            entity.Owner = model.Owner;
            entity.Keywords = model.Keywords;

            _websiteDataRepository.Update(entity);

            CreateMessage("Değişiklikler başarılı bir şekilde kaydedildi.", "success");
            return Redirect("/Admin/WebsiteData/Index");
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

using DayininCiftligiNetCore5.Areas.Admin.Models;
using DayininCiftligiNetCore5.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            return View(model);
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
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alerttype
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
        }
    }
}

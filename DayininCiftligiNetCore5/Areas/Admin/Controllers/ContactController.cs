using DayininCiftligiNetCore5.Areas.Admin.Models;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        private readonly ISectionRepository _sectionRepository;
        public ContactController(IContactRepository contactRepository, ISectionRepository sectionRepository)
        {
            _contactRepository = contactRepository;
            _sectionRepository = sectionRepository;
        }
        public IActionResult Index()
        {
            var model = _contactRepository.GetFirstVisible();
            var section = _sectionRepository.GetById(4);

            ViewBag.Section = new SectionAdminModel()
            {
                Id = section.Id,
                Name = section.Name,
                Description = section.Description,
                ButtonText = section.ButtonText,
                ButtonUrl = section.ButtonUrl,
                DisplayOrder = section.DisplayOrder,
                IsVisible = section.IsVisible,
                ReturnUrl = "/Admin/Contact/Index",
                PageId = 3.6
            };

            ViewBag.PageId = 3.6;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Contact model)
        {
            if (!ModelState.IsValid)
            {
                CreateMessage("Beklenmeyen bir hata oluştu.", "warning");
                return Redirect("/Admin/Contact/Index");
            }
            var entity = _contactRepository.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Address = model.Address;
            entity.City = model.City;
            entity.GoogleMapsUrl = model.GoogleMapsUrl;
            entity.Email = model.Email;
            entity.Phone = model.Phone;
            entity.FbUserName = model.FbUserName;
            entity.InstaUserName = model.InstaUserName;

            _contactRepository.Update(entity);

            ViewBag.PageId = 3.6;
            CreateMessage("Değişiklikler başarılı bir şekilde kaydedildi.", "success");
            return Redirect("/Admin/Contact/Index");
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

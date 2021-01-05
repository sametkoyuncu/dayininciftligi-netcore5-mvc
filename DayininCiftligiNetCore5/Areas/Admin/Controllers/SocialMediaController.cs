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
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaRepository _socialMediaRepository;
        public SocialMediaController(ISocialMediaRepository socialMediaRepository)
        {
            _socialMediaRepository = socialMediaRepository;
        }
        public IActionResult Index()
        {
            var model = _socialMediaRepository.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(SocialMediaModel model)
        {
            if(!ModelState.IsValid)
            {
                CreateMessage("Lütfen bilgileri kontrol edip tekrar deneyiniz.", "warning");
                return Redirect("/Admin/SocialMedia/Index");
            }

            var entity = new SocialMedia()
            {
                Name = model.Name,
                Url = model.Url,
                Icon = model.Icon,
                DisplayOrder = model.DisplayOrder,
                IsVisible = model.IsVisible
            };
            _socialMediaRepository.Create(entity);

            CreateMessage($"{model.Name} hesabınız başarı ile eklendi.", "success");
            return Redirect("/Admin/SocialMedia/Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _socialMediaRepository.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new SocialMediaModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Url = entity.Url,
                Icon = entity.Icon,
                DisplayOrder = entity.DisplayOrder,
                IsVisible = entity.IsVisible
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(SocialMediaModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            var entity = _socialMediaRepository.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Url = model.Url;
            entity.Icon = model.Icon;
            entity.DisplayOrder = model.DisplayOrder;
            entity.IsVisible = model.IsVisible;

            _socialMediaRepository.Update(entity);

            CreateMessage($"{model.Name} hesabınız başarı ile düzenlendi.", "success");
            return Redirect("/Admin/SocialMedia/Index");
        }
        
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var entity = _socialMediaRepository.GetById(Id);

            if(entity == null)
            {
                return NotFound();
            }

            _socialMediaRepository.Delete(entity);
            CreateMessage($"{entity.Name} hesabınız başarı ile silindi.", "success");
            return Redirect("/Admin/SocialMedia/Index");
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

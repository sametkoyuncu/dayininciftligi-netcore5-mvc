using DayininCiftligiNetCore5.Areas.Admin.Models;
using DayininCiftligiNetCore5.Interfaces;
using Microsoft.AspNetCore.Http;
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
    public class SectionController : Controller
    {
        private readonly ISectionRepository _sectionRepository;

        public SectionController(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Edit(int Id, string Name, string Description, string ButtonText, 
            string ButtonUrl, int DisplayOrder, int IsVisible, string ReturnUrl, double PageId)
        {
            var entity = _sectionRepository.GetById(Id);
            if(entity == null)
            {
                CreateMessage("Bölüm bulunamadı.","danger");
                return NotFound();
            }

            entity.Name = Name;
            entity.Description = Description;
            entity.ButtonText = ButtonText;
            entity.ButtonUrl = ButtonUrl;
            entity.DisplayOrder = DisplayOrder;
            if(IsVisible == 1)
                entity.IsVisible = true;
            else
                entity.IsVisible = false;

            _sectionRepository.Update(entity);

            CreateMessage("Değişiklikler başarılı bir şeklde kaydedildi..", "success");
            ViewBag.PageId = PageId;
            return Redirect(ReturnUrl);
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

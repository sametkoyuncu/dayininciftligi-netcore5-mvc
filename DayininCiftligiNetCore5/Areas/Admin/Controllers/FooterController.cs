using DayininCiftligiNetCore5.Areas.Admin.Models;
using DayininCiftligiNetCore5.Entities;
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
    public class FooterController : Controller
    {
        private readonly IFooterWidgetRepository _footerRepository;
        public FooterController(IFooterWidgetRepository footerRepository)
        {
            _footerRepository = footerRepository;
        }
        public IActionResult Index()
        {
            var model = _footerRepository.GetFirstTwoWidgets();
            ViewBag.PageId = 3.7;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(FooterWidget model, IFormFile fileImage)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = _footerRepository.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Header = model.Header;
            entity.Body = model.Body;
            //entity.IsVisible = model.IsVisible;


            if (fileImage != null)
            {
                var deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\logos", entity.ImageUrl);

                var extension = Path.GetExtension(fileImage.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                entity.ImageUrl = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\logos", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileImage.CopyToAsync(stream);
                }

                if (System.IO.File.Exists(deletePath))
                {
                    System.IO.File.Delete(deletePath);
                }
            }
            else
            {
                entity.ImageUrl = model.ImageUrl;
            }

            _footerRepository.Update(entity);

            ViewBag.PageId = 3.7;
            CreateMessage($"Widget başarı ile düzenlendi.", "success");
            return Redirect("/Admin/Footer/Index");
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

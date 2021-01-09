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
        private readonly IHomeBannerRepository _homeBannerRepository;

        public SectionController(IHomeBannerRepository homeBannerRepository)
        {
            _homeBannerRepository = homeBannerRepository;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult HomeBanner()
        {
            var model = _homeBannerRepository.GetFirstVisible();
            ViewBag.PageId = 3.2;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> HomeBannerEdit(HomeBannerModel model, IFormFile fileBgImage)
        {
            if (!ModelState.IsValid)
            {
                CreateMessage("Beklenmeyen bir hata oluştu.", "warning");
                return Redirect("/Admin/Section/HomeBanner");
            }
            var entity = _homeBannerRepository.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Header = model.Header;
            entity.Text = model.Text;
            entity.ButtonText = model.ButtonText;
            entity.ButtonUrl = model.ButtonUrl;
            entity.BgImageUrl = model.BgImageUrl;

            if (fileBgImage != null)
            {
                var extension = Path.GetExtension(fileBgImage.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                entity.BgImageUrl = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\bg", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileBgImage.CopyToAsync(stream);
                }
            }

            _homeBannerRepository.Update(entity);

            ViewBag.PageId = 3.2;
            CreateMessage("Değişiklikler başarılı bir şekilde kaydedildi.", "success");
            return Redirect("/Admin/Section/HomeBanner");
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

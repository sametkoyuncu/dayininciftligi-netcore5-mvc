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
    public class GalleryController : Controller
    {
        private readonly IGalleryImagesRepository _galleryImagesRepository;
        private readonly ISectionRepository _sectionRepository;
        public GalleryController(IGalleryImagesRepository galleryImagesRepository, ISectionRepository sectionRepository)
        {
            _galleryImagesRepository = galleryImagesRepository;
            _sectionRepository = sectionRepository;
        }
        public IActionResult Index()
        {
            var model = _galleryImagesRepository.GetAll();
            var section = _sectionRepository.GetById(12);

            ViewBag.Section = new SectionAdminModel(){
                Id = section.Id,
                Name = section.Name,
                Description = section.Description,
                ButtonText = section.ButtonText,
                ButtonUrl = section.ButtonUrl,
                DisplayOrder = section.DisplayOrder,
                IsVisible = section.IsVisible,
                ReturnUrl = "/Admin/Gallery/Index",
                PageId = 3.4
            };
            ViewBag.PageId = 3.4;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(GalleryImage model, IFormFile fileImage)
        {
            if (!ModelState.IsValid)
            {
                CreateMessage("Beklenmeyen bir hata oluştu.", "warning");
                ViewBag.PageId = 3.4;
                return Redirect("/Admin/Gallery/Index");
            }

            var entity = new GalleryImage()
            {
                ImageAltText = model.ImageAltText,
                DisplayOrder = model.DisplayOrder
            };

            if (fileImage != null)
            {
                var extension = Path.GetExtension(fileImage.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                entity.ImageUrl = "https://localhost:44385/img/gallery/" + randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\gallery", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileImage.CopyToAsync(stream);
                }
            }

            _galleryImagesRepository.Create(entity);

            ViewBag.PageId = 3.4;
            CreateMessage($"Görsel başarı ile eklendi.", "success");
            return Redirect("/Admin/Gallery/Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _galleryImagesRepository.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new GalleryImage()
            {
                Id = entity.Id,
                ImageUrl = entity.ImageUrl,
                ImageAltText = entity.ImageAltText,
                DisplayOrder = entity.DisplayOrder,
                IsVisible = entity.IsVisible,
                IsHome = entity.IsHome
            };
            ViewBag.PageId = 3.4;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(GalleryImage model, IFormFile fileImage)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = _galleryImagesRepository.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.DisplayOrder = model.DisplayOrder;
            entity.ImageAltText = model.ImageAltText;
            entity.IsVisible = model.IsVisible;
            entity.IsHome = model.IsHome;


            if (fileImage != null)
            {
                var deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\gallery", entity.ImageUrl);

                var extension = Path.GetExtension(fileImage.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                entity.ImageUrl = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\gallery", randomName);

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

            _galleryImagesRepository.Update(entity);

            ViewBag.PageId = 3.4;
            CreateMessage($"Görsel başarı ile düzenlendi.", "success");
            return Redirect("/Admin/Gallery/Index");
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var entity = _galleryImagesRepository.GetById(Id);

            if (entity == null)
            {
                return NotFound();
            }

            //Image Delete
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\gallery", entity.ImageUrl);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _galleryImagesRepository.Delete(entity);
            CreateMessage($"Görsel başarı ile silindi.", "success");

            ViewBag.PageId = 3.4;
            return Redirect("/Admin/Gallery/Index");
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

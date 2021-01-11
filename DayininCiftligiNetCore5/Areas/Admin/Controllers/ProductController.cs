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
    public class ProductController : Controller
    {

        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var model = _productRepository.GetAll();

            ViewBag.PageId = 3.3;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductModel model, IFormFile fileImage)
        {
            if (!ModelState.IsValid)
            {
                CreateMessage("Beklenmeyen bir hata oluştu.", "warning");
                return Redirect("/Admin/Product/Index");
            }
            
            var entity = new Product()
            {
                Name = model.Name,
                ImageAltText = model.ImageAltText,
                DisplayOrder = model.DisplayOrder,
                IsVisible = model.IsVisible
            };

            if (fileImage != null)
            {
                var extension = Path.GetExtension(fileImage.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                entity.ImageUrl = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\products", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileImage.CopyToAsync(stream);
                }
            }

            _productRepository.Create(entity);

            ViewBag.PageId = 3.2;
            CreateMessage($"{model.Name} ürünü başarı ile eklendi.", "success");
            return Redirect("/Admin/Product/Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _productRepository.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new ProductModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                ImageUrl = entity.ImageUrl,
                ImageAltText = entity.ImageAltText,
                DisplayOrder = entity.DisplayOrder,
                IsVisible = entity.IsVisible
            };
            ViewBag.PageId = 3.2;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductModel model, IFormFile fileImage)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = _productRepository.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.DisplayOrder = model.DisplayOrder;
            entity.ImageAltText = model.ImageAltText;
            entity.IsVisible = model.IsVisible;


            if (fileImage != null)
            {
                var extension = Path.GetExtension(fileImage.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                entity.ImageUrl = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\products", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileImage.CopyToAsync(stream);
                }
            }
            else
            {
                entity.ImageUrl = model.ImageUrl;
            }

            _productRepository.Update(entity);

            ViewBag.PageId = 3.2;
            CreateMessage($"{model.Name} ürünü başarı ile düzenlendi.", "success");
            return Redirect("/Admin/Product/Index");
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var entity = _productRepository.GetById(Id);

            if (entity == null)
            {
                return NotFound();
            }

            //Image Delete
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\products", entity.ImageUrl);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _productRepository.Delete(entity);
            CreateMessage($"{entity.Name} ürünü başarı ile silindi.", "success");

            ViewBag.PageId = 3.2;
            return Redirect("/Admin/Product/Index");
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

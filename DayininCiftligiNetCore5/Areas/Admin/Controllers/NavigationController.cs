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
    public class NavigationController : Controller
    {
        private readonly INavItemRepository _navItemRepository;
        public NavigationController(INavItemRepository navItemRepository)
        {
            _navItemRepository = navItemRepository;
        }
        public IActionResult Index()
        {
            var model = _navItemRepository.GetAll();
            ViewBag.PageId = 3.1;
            return View(model);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _navItemRepository.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new NavItemModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Url = entity.Url,
                DisplayOrder = entity.DisplayOrder,
                IsVisible = entity.IsVisible
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(NavItemModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = _navItemRepository.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Url = model.Url;
            entity.DisplayOrder = model.DisplayOrder;
            entity.IsVisible = model.IsVisible;

            _navItemRepository.Update(entity);

            CreateMessage($"'{model.Name}' isimli menü başarı ile düzenlendi.", "success");
            return Redirect("/Admin/Navigation/Index");
        }

        [HttpPost]
        public IActionResult Create(NavItemModel model)
        {
            if (!ModelState.IsValid)
            {
                CreateMessage("Lütfen bilgileri kontrol edip tekrar deneyiniz.", "warning");
                return Redirect("/Admin/Navigation/Index");
            }

            var entity = new NavItem()
            {
                Name = model.Name,
                Url = model.Url,
                DisplayOrder = model.DisplayOrder,
                IsVisible = model.IsVisible
            };
            _navItemRepository.Create(entity);

            CreateMessage($"{model.Name} hesabınız başarı ile eklendi.", "success");
            return Redirect("/Admin/Navigation/Index");
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var entity = _navItemRepository.GetById(Id);

            if (entity == null)
            {
                return NotFound();
            }

            _navItemRepository.Delete(entity);
            CreateMessage($"'{entity.Name}' isimli menü başarı ile silindi.", "success");
            return Redirect("/Admin/Navigation/Index");
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

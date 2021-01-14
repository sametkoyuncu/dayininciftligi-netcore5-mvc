using DayininCiftligiNetCore5.Areas.Admin.Models;
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
    public class SubscriberController : Controller
    {
        private readonly ISubscriberRepository _subscriberRepository;
        public SubscriberController(ISubscriberRepository subscriberRepository)
        {
            _subscriberRepository = subscriberRepository;
        }
        public IActionResult Index()
        {
            var model = _subscriberRepository.GetAll();
            ViewBag.PageId = 5;
            return View(model);
        }

        [HttpPost]
        public IActionResult MoveToNotActive(int Id)
        {
            var entity = _subscriberRepository.GetById(Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.IsDeleted = true;

            _subscriberRepository.Update(entity);
            CreateMessage($"{entity.Email} pasif hale getirildi.", "success");
            ViewBag.PageId = 4.3;
            return Redirect("/Admin/Subscriber/Index");
        }

        [HttpPost]
        public IActionResult MoveToActive(int Id)
        {
            var entity = _subscriberRepository.GetById(Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.IsDeleted = false;

            _subscriberRepository.Update(entity);
            CreateMessage($"{entity.Email} aktif hale getirildi.", "success");
            ViewBag.PageId = 4.3;
            return Redirect("/Admin/Subscriber/Index");
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

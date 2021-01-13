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
    public class MessageController : Controller
    {
        private readonly IMessageRepository _messageRepository;
        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public IActionResult Index()
        {
            var model = _messageRepository.GetMessages();
            ViewBag.PageId = 4.1;
            return View(model);
        }

        public IActionResult Archive()
        {
            var model = _messageRepository.GetArchived();
            ViewBag.PageId = 4.2;
            return View(model);
        }

        public IActionResult Trash()
        {
            var model = _messageRepository.GetDeleted();
            ViewBag.PageId = 4.3;
            return View(model);
        }

        public IActionResult Read(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _messageRepository.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.IsRead = true;

            _messageRepository.Update(entity);

            var model = new Message()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Subject = entity.Subject,
                Text = entity.Text,
                IsRead = entity.IsRead,
                IsArchived = entity.IsArchived,
                IsDeleted = entity.IsDeleted
            };
            ViewBag.PageId = 4.1;
            return View(model);
        }

        [HttpPost]
        public IActionResult NotRead(int Id)
        {
            var entity = _messageRepository.GetById(Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.IsRead = false;

            _messageRepository.Update(entity);
            CreateMessage($"{entity.Subject} okunmadı sayıldı.", "success");
            ViewBag.PageId = 4.1;
            return Redirect("/Admin/Message/Index");
        }

        [HttpPost]
        public IActionResult MoveToArchive(int Id)
        {
            var entity = _messageRepository.GetById(Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.IsArchived = true;

            _messageRepository.Update(entity);
            CreateMessage($"{entity.Subject} arşivlendi.", "success");
            ViewBag.PageId = 4.2;
            return Redirect("/Admin/Message/Read/" + Id);
        }

        [HttpPost]
        public IActionResult MoveToTrash(int Id)
        {
            var entity = _messageRepository.GetById(Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.IsDeleted = true;

            _messageRepository.Update(entity);
            CreateMessage($"{entity.Subject} çöp kutusuna taşındı.", "success");
            ViewBag.PageId = 4.3;
            return Redirect("/Admin/Message/Read/" + Id);
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

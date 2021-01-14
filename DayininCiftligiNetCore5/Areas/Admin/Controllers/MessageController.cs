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
            var emails = _messageRepository.GetMessages();
            ViewBag.PageId = 4.1;
            var model = new MessageModel()
            {
                Messages = emails,
                ReturnUrlMessageAction = "Index"
            };
            return View(model);
        }

        public IActionResult Archive()
        {
            var emails = _messageRepository.GetArchived();
            ViewBag.PageId = 4.2;
            var model = new MessageModel()
            {
                Messages = emails,
                ReturnUrlMessageAction = "Archive"
            };
            return View(model);
        }

        public IActionResult Trash()
        {
            var emails = _messageRepository.GetDeleted();
            ViewBag.PageId = 4.3;
            var model = new MessageModel()
            {
                Messages = emails,
                ReturnUrlMessageAction = "Trash"
            };
            return View(model);
        }

        [Route("/Admin/Message/Read/{id}/{returnUrlMessageAction}")]
        public IActionResult Read(int? id, string returnUrlMessageAction)
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

            var model = new ReadMessageModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Subject = entity.Subject,
                Text = entity.Text,
                IsRead = entity.IsRead,
                IsArchived = entity.IsArchived,
                IsDeleted = entity.IsDeleted,
                ReturnUrlMessageAction = returnUrlMessageAction
            };
            ViewBag.PageId = 4;
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
        public IActionResult MoveToArchive(int Id, string ReturnUrl)
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
            return Redirect(ReturnUrl);
        }

        [HttpPost]
        public IActionResult MoveToTrash(int Id, string ReturnUrl)
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
            return Redirect(ReturnUrl);
        }

        [HttpPost]
        public IActionResult MoveToInbox(int Id, string ReturnUrl)
        {
            var entity = _messageRepository.GetById(Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.IsArchived = false;
            entity.IsDeleted = false;

            _messageRepository.Update(entity);
            CreateMessage($"{entity.Subject} gelen kutusuna taşındı.", "success");
            ViewBag.PageId = 4.1;
            return Redirect(ReturnUrl);
        }

        [HttpPost]
        public IActionResult MoveToInboxRead(int Id)
        {
            var entity = _messageRepository.GetById(Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.IsArchived = false;
            entity.IsDeleted = false;

            _messageRepository.Update(entity);
            CreateMessage($"{entity.Subject} gelen kutusuna taşındı.", "success");
            ViewBag.PageId = 4.1;
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

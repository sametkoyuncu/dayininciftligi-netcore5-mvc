using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using DayininCiftligiNetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISectionRepository _sectionRepository;
        private readonly IGalleryImagesRepository _galleryImagesRepository;
        private readonly IMessageRepository _messageRepository;
        private readonly ISubscriberRepository _subscriberRepository;

        public HomeController(ILogger<HomeController> logger,
            ISectionRepository sectionRepository,
            IGalleryImagesRepository galleryImagesRepository,
            IMessageRepository messageRepository,
            ISubscriberRepository subscriberRepository)
        {
            _logger = logger;
            _sectionRepository = sectionRepository;
            _galleryImagesRepository = galleryImagesRepository;
            _messageRepository = messageRepository;
            _subscriberRepository = subscriberRepository;
        }

        public IActionResult Index()
        {
            return View(_sectionRepository.GetByDisplayOrder());
        }

        public IActionResult GalleryPage()
        {
            ViewBag.GalleryPageBannerData = new PageBannerModel()
            {
                Header="Galeri",
                MasterPage="Anasayfa",
                MasterPageUrl="/",
                ThisPage="Galeri",
                ThisPageUrl="/Galeri"
            };
            return View(_galleryImagesRepository.GetVisibleImages());
        }

        [HttpPost]
        public IActionResult SendMessage(MessageModel model)
        {
            if (!ModelState.IsValid)
            {
                CreateMessage("Mesaj gönderirken bir hata oluştu. Lütfen tekrar deneyiniz. Hata devam ederse <a href='mailto: @Model.Email'>@Model.EmailForContact</a> adresine eposta gönderebilirsiniz.", "danger");
                return Redirect("/Index#mesajgonder");
            }
            
            var message = new Message()
            {
                Name = model.Name,
                Email = model.Email,
                Subject = model.Subject,
                Text = model.Text
            };

            _messageRepository.Create(message);
            CreateMessage("Mesajını aldık, en kısa sürede geri dönüş yapacağız.", "success");
            return Redirect("/Index#mesajgonder");
        }

        [HttpPost]
        public IActionResult AddSubscriber(Subscriber model)
        {
            if (ModelState.IsValid)
            {
                _subscriberRepository.Create(model);
                CreateMessage("Haber bültenimize kayıt olduğun için teşekkürler.", "success");
                return Redirect("/Index#mesajgonder");
            }
            CreateMessage("Bültene kayıt olurken bir hata oluştu. Lütfen tekrar deneyiniz. Hata devam ederse <a href='mailto: @Model.Email'>@Model.EmailForContact</a> adresine eposta gönderebilirsiniz.", "danger");
            return Redirect("/Index#mesajgonder");
        }

        public IActionResult NotFound(int code)
        {
            ViewBag.StatusCode = code;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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

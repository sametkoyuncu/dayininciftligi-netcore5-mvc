using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using DayininCiftligiNetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.ViewComponents
{
    public class ContactComponent: ViewComponent
    {
        private readonly IContactRepository _contactRepository;
        public ContactComponent(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public IViewComponentResult Invoke()
        {
            var contact = _contactRepository.GetFirstVisible();
            //indexte doluyor
            var sectionData = ViewData["ContactComponent"] as SectionModel;
            var model = new ContactSectionModel()
            {
                Address = contact.Address,
                City = contact.City,
                EmailForContact = contact.Email,
                Phone = contact.Phone,
                FbUserName = contact.FbUserName,
                InstaUserName = contact.InstaUserName,
                SectionName = sectionData.Name
            };
            return View(model);
        }
    }
}

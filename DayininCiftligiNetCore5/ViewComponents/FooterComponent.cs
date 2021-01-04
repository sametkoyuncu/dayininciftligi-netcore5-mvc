using DayininCiftligiNetCore5.Interfaces;
using DayininCiftligiNetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.ViewComponents
{
    public class FooterComponent : ViewComponent
    {
        private readonly INavItemRepository _navItemRepository;
        private readonly IContactRepository _contactRepository;
        private readonly IFooterWidgetRepository _footerWidgetRepository;
        private readonly IWebsiteDataRepository _websiteDataRepository;
        private readonly ISocialMediaRepository _socialMediaRepository;
        public FooterComponent(
            INavItemRepository navItemRepository, 
            IContactRepository contactRepository, 
            IFooterWidgetRepository footerWidgetRepository,
            IWebsiteDataRepository websiteDataRepository,
            ISocialMediaRepository socialMediaRepository)
        {
            _navItemRepository = navItemRepository;
            _contactRepository = contactRepository;
            _footerWidgetRepository = footerWidgetRepository;
            _websiteDataRepository = websiteDataRepository;
            _socialMediaRepository = socialMediaRepository;
        }
        
        public IViewComponentResult Invoke()
        {
            var navItems = _navItemRepository.GetByDisplayOrder();
            var contact = _contactRepository.GetFooterContactInfos();
            var footerWidgets = _footerWidgetRepository.GetFirstTwoWidgets();
            var socialMedias = _socialMediaRepository.GetByDisplayOrder();
            var model = new FooterModel() {
                Address = contact.Address,
                City = contact.City,
                Phone = contact.Phone,
                Email = contact.Email,
                NavItems = navItems,
                FooterWidgets = footerWidgets,
                SocialMedias = socialMedias
            };
            ViewBag.CopyrightForFooter = _websiteDataRepository.GetCopyrightForFooter();
            return View(model);
        }
    }
}

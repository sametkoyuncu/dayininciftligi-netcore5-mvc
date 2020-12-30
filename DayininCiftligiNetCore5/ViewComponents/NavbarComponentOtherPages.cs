using DayininCiftligiNetCore5.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.ViewComponents
{
    public class NavbarComponentOtherPages : ViewComponent
    {
        private readonly INavItemRepository _navItemRepository;
        private readonly IWebsiteDataRepository _websiteDataRepository;
        public NavbarComponentOtherPages(INavItemRepository navItemRepository, IWebsiteDataRepository websiteDataRepository)
        {
            _navItemRepository = navItemRepository;
            _websiteDataRepository = websiteDataRepository;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Logo = _websiteDataRepository.GetLogo();
            return View(_navItemRepository.GetByDisplayOrder());
        }
    }
}

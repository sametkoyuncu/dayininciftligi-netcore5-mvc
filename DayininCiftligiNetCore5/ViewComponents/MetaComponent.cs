using DayininCiftligiNetCore5.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.ViewComponents
{
    public class MetaComponent : ViewComponent
    {
        private readonly IWebsiteDataRepository _websiteDataRepository;
        public MetaComponent(IWebsiteDataRepository websiteDataRepository)
        {
            _websiteDataRepository = websiteDataRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_websiteDataRepository.GetMetaData());
        }
    }
}

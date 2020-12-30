using DayininCiftligiNetCore5.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.ViewComponents
{
    public class HomeBannerComponent: ViewComponent
    {
        private readonly IHomeBannerRepository _homeBannerRepository;
        public HomeBannerComponent(IHomeBannerRepository homeBannerRepository)
        {
            _homeBannerRepository = homeBannerRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_homeBannerRepository.GetFirstVisible());
        }
    }
}

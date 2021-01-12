using DayininCiftligiNetCore5.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.ViewComponents
{
    public class GalleryImageCreateComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new GalleryImage());
        }
    }
}

using DayininCiftligiNetCore5.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.ViewComponents
{
    public class NavItemCreateComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new NavItemModel());
        }
    }
}

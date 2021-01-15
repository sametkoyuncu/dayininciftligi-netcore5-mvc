using DayininCiftligiNetCore5.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            if(!User.Identity.IsAuthenticated)
            {
                return Redirect("/Login");
            }
            var model = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.PageId = 99;
            return View(model);
        }
    }
}

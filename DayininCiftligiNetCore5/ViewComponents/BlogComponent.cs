using DayininCiftligiNetCore5.Interfaces;
using DayininCiftligiNetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.ViewComponents
{
    public class BlogComponent: ViewComponent
    {
        private readonly IBlogRepository _blogRepository;
        public BlogComponent(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public IViewComponentResult Invoke()
        {
            var homeBlogs = _blogRepository.GetLastThreeBlogs();
            //indexte doluyor
            var sectionData = ViewData["BlogComponent"] as SectionModel;
            var model = new BlogSectionModel()
            {
                Name = sectionData.Name,
                Description = sectionData.Description,
                ButtonText = sectionData.ButtonText,
                ButtonUrl = sectionData.ButtonUrl,
                HomeBlogModels = homeBlogs
            };
            return View(model);
        }
    }
}

using DayininCiftligiNetCore5.Interfaces;
using DayininCiftligiNetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public IActionResult Details(string url)
        {
            ViewBag.BlogPageBannerData = new PageBannerModel()
            {
                Header = "Blog",
                MasterPage = "Anasayfa",
                MasterPageUrl = "/",
                ThisPage = "Blog",
                ThisPageUrl = "/blog"
            };
            var blogPost = _blogRepository.GetBlogByUrl(url);
            var model = new BlogModel()
            {
                BlogId = blogPost.Id,
                Header = blogPost.Header,
                SubHeader = blogPost.SubHeader,
                CoverImageUrl = blogPost.CoverImageUrl,
                Text = blogPost.Text,
                Created = blogPost.Created
            };
            return View(model);
        }
    }
}

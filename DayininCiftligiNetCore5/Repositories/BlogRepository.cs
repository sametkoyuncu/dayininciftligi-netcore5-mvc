using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using DayininCiftligiNetCore5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public Blog GetBlogByUrl(string url)
        {
            var context = new DayiDbContext();
            return context.Blogs
                            .Where(b => b.IsVisible && b.Url == url)
                            .FirstOrDefault();
        }

        public List<HomeBlogModel> GetLastThreeBlogs()
        {
            var context = new DayiDbContext();
            return context.Blogs
                            .OrderBy(b => b.Created)
                            .Where(b=>b.IsVisible == true)
                            .Take(3)
                            .Select(m => new HomeBlogModel() { 
                                Header = m.Header,
                                SmallImageUrl = m.SmallImageUrl,
                                Url = m.Url
                            })
                            .ToList();
        }
    }
}

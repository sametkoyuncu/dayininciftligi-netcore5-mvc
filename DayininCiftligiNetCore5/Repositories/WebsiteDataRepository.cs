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
    public class WebsiteDataRepository : GenericRepository<WebsiteData>, IWebsiteDataRepository
    {
        public string GetCopyrightForFooter()
        {
            var context = new DayiDbContext();
            return context.WebsiteDatas
                            .Where(wd => wd.IsVisible == true)
                            .Select(wd => wd.CopyrightForFooter)
                            .FirstOrDefault();
        }

        public string GetLogo()
        {
            var context = new DayiDbContext();
            return context.WebsiteDatas
                            .Where(wd => wd.IsVisible == true)
                            .Select(wd => wd.Logo)
                            .FirstOrDefault();
        }

        public MetaModel GetMetaData()
        {
            var context = new DayiDbContext();
            return context.WebsiteDatas
                            .Where(wd => wd.IsVisible == true)
                            .Select(wd => new MetaModel()
                            {
                                Title = wd.Title,
                                Description = wd.Description,
                                Keywords = wd.Keywords,
                                Author = wd.Author,
                                Owner = wd.Owner,
                                Favicon = wd.Favicon,
                                CopyrightForMeta = wd.CopyrightForMeta
                            })
                            .FirstOrDefault();
        }
    }
}

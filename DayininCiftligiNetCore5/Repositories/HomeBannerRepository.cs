using DayininCiftligiNetCore5.Areas.Admin.Models;
using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class HomeBannerRepository : GenericRepository<HomeBanner>, IHomeBannerRepository
    {
        public HomeBannerModel GetFirstVisible()
        {

            using var context = new DayiDbContext();

            return context.HomeBanners
                .Where(h => h.IsVisible == true)
                .Select(m => new HomeBannerModel()
                {
                    Id = m.Id,
                    Header = m.Header,
                    Text = m.Text,
                    ButtonText = m.ButtonText,
                    ButtonUrl = m.ButtonUrl,
                    BgImageUrl = m.BgImageUrl
                })
                .FirstOrDefault();
        }
    }
}

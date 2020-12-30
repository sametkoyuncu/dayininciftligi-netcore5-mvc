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
        public HomeBanner GetFirstVisible()
        {

            using var context = new DayiDbContext();

            return context.HomeBanners
                .Where(h => h.IsVisible == true)
                .FirstOrDefault();
        }
    }
}

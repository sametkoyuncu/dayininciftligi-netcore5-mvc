using DayininCiftligiNetCore5.Areas.Admin.Models;
using DayininCiftligiNetCore5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Interfaces
{
    public interface IHomeBannerRepository : IGenericRepository<HomeBanner>
    {
        HomeBannerModel GetFirstVisible();
    }
}

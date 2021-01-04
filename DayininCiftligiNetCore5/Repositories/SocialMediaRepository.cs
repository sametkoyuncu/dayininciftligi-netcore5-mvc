using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class SocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaRepository
    {
        public List<SocialMedia> GetByDisplayOrder()
        {
            using var context = new DayiDbContext();

            return context.SocialMedias
                .Where(s => s.IsVisible == true)
                .OrderBy(s => s.DisplayOrder)
                .ToList();
        }
    }
}

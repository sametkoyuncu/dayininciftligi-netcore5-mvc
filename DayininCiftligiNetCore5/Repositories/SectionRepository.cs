using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class SectionRepository : GenericRepository<Section>, ISectionRepository
    {
        public Section GetByComponentName(string ComponentName)
        {
            using var context = new DayiDbContext();
            return context.Sections
                .Where(s => s.ComponentName == ComponentName)
                .FirstOrDefault();
        }

        public List<Section> GetByDisplayOrder()
        {
            using var context = new DayiDbContext();

            return context.Sections
                .Where(s => s.IsVisible == true)
                .OrderBy(s => s.DisplayOrder)
                .ToList();
        }
    }
}

using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class NavItemRepository : GenericRepository<NavItem>, INavItemRepository
    {
        public List<NavItem> GetByDisplayOrder()
        {
            using var context = new DayiDbContext();

            return context.NavItems
                .Where(n=>n.IsVisible)
                .OrderBy(n => n.DisplayOrder)
                .ToList();
        }
    }
}

using DayininCiftligiNetCore5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Interfaces
{
    public interface INavItemRepository : IGenericRepository<NavItem>
    {
        List<NavItem> GetByDisplayOrder();
    }
}

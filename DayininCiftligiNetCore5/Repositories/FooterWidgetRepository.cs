using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class FooterWidgetRepository : GenericRepository<FooterWidget>, IFooterWidgetRepository
    {
        public List<FooterWidget> GetFirstTwoWidgets()
        {
            var context = new DayiDbContext();
            return context.FooterWidgets
                            .Where(b => b.IsVisible == true)
                            .Take(2)
                            .ToList();
        }
    }
}

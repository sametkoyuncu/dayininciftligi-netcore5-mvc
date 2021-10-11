using DayininCiftligiNetCore5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Interfaces
{
    public interface ISectionRepository : IGenericRepository<Section>
    {
        List<Section> GetByDisplayOrder();
        Section GetByComponentName(string ComponentName);
    }
}

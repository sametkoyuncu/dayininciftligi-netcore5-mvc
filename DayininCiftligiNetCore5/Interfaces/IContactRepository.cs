using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Interfaces
{
    public interface IContactRepository : IGenericRepository<Contact>
    {
        Contact GetFirstVisible();
        FooterModel GetFooterContactInfos();
    }
}

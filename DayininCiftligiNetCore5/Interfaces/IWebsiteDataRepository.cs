using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Interfaces
{
    public interface IWebsiteDataRepository : IGenericRepository<WebsiteData>
    {
        MetaModel GetMetaData();
        String GetLogo();
        String GetCopyrightForFooter();
    }
}

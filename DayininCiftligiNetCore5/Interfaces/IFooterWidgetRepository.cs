﻿using DayininCiftligiNetCore5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Interfaces
{
    public interface IFooterWidgetRepository : IGenericRepository<FooterWidget>
    {
        List<FooterWidget> GetFirstTwoWidgets();
    }
}

﻿using DayininCiftligiNetCore5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetVisibles();
    }
}

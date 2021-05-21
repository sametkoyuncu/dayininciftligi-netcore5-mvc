using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public List<Product> GetVisibles()
        {
            
                using var context = new DayiDbContext();

                return context.Set<Product>().Where(x=> x.IsVisible == true).ToList();
            
        }
    }
}

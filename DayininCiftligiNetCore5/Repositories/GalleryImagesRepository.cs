using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class GalleryImagesRepository : GenericRepository<GalleryImage>, IGalleryImagesRepository
    {
        public List<GalleryImage> GetHomePageImages()
        {
            using var context = new DayiDbContext();

            return context.GalleryImages
                .Where(i => i.IsHome == true)
                .ToList();
        }

        public List<GalleryImage> GetVisibleImages()
        {
            using var context = new DayiDbContext();

            return context.GalleryImages
                .Where(i => i.IsVisible == true)
                .ToList();
        }
    }
}

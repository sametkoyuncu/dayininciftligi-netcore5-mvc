using DayininCiftligiNetCore5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Interfaces
{
    public interface IGalleryImagesRepository : IGenericRepository<GalleryImage>
    {
        List<GalleryImage> GetHomePageImages();
        List<GalleryImage> GetVisibleImages();
    }
}

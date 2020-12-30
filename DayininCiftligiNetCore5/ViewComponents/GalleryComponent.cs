using DayininCiftligiNetCore5.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.ViewComponents
{
    public class GalleryComponent: ViewComponent
    {
        private readonly IGalleryImagesRepository _galleryImagesRepository;
        public GalleryComponent(IGalleryImagesRepository galleryImagesRepository)
        {
            _galleryImagesRepository = galleryImagesRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_galleryImagesRepository.GetHomePageImages());
        }
    }
}

using DayininCiftligiNetCore5.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.ViewComponents
{
    public class ProductsComponent: ViewComponent
    {
        private readonly IProductRepository _productRepository;
        public ProductsComponent(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_productRepository.GetVisibles());
        }
    }
}

using DayininCiftligiNetCore5.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAltText { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsVisible { get; set; }
    }
}

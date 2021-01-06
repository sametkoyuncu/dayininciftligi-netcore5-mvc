using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Models
{
    public class NavItemModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsVisible { get; set; }
    }
}

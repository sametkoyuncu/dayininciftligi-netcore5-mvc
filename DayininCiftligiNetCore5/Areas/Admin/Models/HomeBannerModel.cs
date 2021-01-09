using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Models
{
    public class HomeBannerModel
    {
        public int Id { get; set; }

        [Required]
        public string Header { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string BgImageUrl { get; set; }

        [Required]
        public string ButtonText { get; set; }

        [Required]
        public string ButtonUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Models
{
    public class SocialMediaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim alanı zorunludur.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bağlantı alanı zorunludur.")]
        public string Url { get; set; }
        [Required(ErrorMessage = "İkon alanı zorunludur.")]
        public string Icon { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        public bool IsVisible { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Models
{
    public class SectionAdminModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ButtonText { get; set; }
        public string ButtonUrl { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsVisible { get; set; }
        public string ReturnUrl { get; set; }
        public double PageId { get; set; }
    }
}

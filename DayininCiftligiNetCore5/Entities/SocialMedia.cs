using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Entities
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsVisible { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Entities
{
    public class HomeBanner
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public string BgImageUrl { get; set; }
        public string ButtonText { get; set; }
        public string ButtonUrl { get; set; }
        public bool IsVisible { get; set; }
    }
}

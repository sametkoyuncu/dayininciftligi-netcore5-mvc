using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Entities
{
    public class FooterWidget
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string ImageUrl { get; set; }
        public bool IsVisible { get; set; }
    }
}

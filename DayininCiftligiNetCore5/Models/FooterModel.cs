using DayininCiftligiNetCore5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Models
{
    public class FooterModel
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<NavItem> NavItems { get; set; }
        public List<FooterWidget> FooterWidgets { get; set; }

    }
}

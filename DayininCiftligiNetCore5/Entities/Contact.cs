using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GoogleMapsUrl { get; set; }
        public string FbUserName { get; set; }
        public string InstaUserName { get; set; }
        public bool IsVisible { get; set; }
    }
}

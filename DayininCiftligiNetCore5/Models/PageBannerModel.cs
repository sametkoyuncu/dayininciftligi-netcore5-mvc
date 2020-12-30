using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Models
{
    public class PageBannerModel
    {
        public string Header { get; set; }
        public string MasterPage { get; set; }
        public string MasterPageUrl { get; set; }
        public string ThisPage { get; set; }
        public string ThisPageUrl { get; set; }
    }
}

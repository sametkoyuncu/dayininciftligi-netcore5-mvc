using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Models
{
    public class BlogModel
    {
        public int BlogId { get; set; }
        public string Header { get; set; }
        public string SubHeader { get; set; }
        public string CoverImageUrl { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
    }
}

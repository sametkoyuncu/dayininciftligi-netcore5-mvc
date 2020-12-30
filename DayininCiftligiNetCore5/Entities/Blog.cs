using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Header { get; set; }
        public string SubHeader { get; set; }
        public string CoverImageUrl { get; set; }
        public string SmallImageUrl { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public bool IsVisible { get; set; }
    }
}

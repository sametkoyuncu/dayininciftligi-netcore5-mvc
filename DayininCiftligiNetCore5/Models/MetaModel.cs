﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Models
{
    public class MetaModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string Author { get; set; }
        public string Owner { get; set; }
        public string Favicon { get; set; }
        public string CopyrightForMeta { get; set; }
    }
}

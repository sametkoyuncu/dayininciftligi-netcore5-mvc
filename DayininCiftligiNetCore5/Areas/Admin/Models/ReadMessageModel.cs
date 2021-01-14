using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Models
{
    public class ReadMessageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public bool IsRead { get; set; }
        public bool IsArchived { get; set; }
        public bool IsDeleted { get; set; }
        public string ReturnUrlMessageAction { get; set; }
    }
}

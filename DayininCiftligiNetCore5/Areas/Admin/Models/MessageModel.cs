using DayininCiftligiNetCore5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Areas.Admin.Models
{
    public class MessageModel
    {
        public List<Message> Messages { get; set; }
        public string ReturnUrlMessageAction { get; set; }
    }
}

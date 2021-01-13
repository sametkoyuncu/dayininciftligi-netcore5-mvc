using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public List<Message> GetArchived()
        {
            var context = new DayiDbContext();
            return context.Messages
                            .Where(m => m.IsArchived)
                            .ToList();
        }

        public List<Message> GetDeleted()
        {
            var context = new DayiDbContext();
            return context.Messages
                            .Where(m => m.IsDeleted)
                            .ToList();
        }

        public List<Message> GetMessages()
        {
            var context = new DayiDbContext();
            return context.Messages
                            .Where(m => !m.IsArchived && !m.IsDeleted)
                            .ToList();
        }
    }
}

using DayininCiftligiNetCore5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Interfaces
{
    public interface IMessageRepository : IGenericRepository<Message>
    {
        // IsDeleted // IsArchive // Others
        List<Message> GetMessages();
        List<Message> GetArchived();
        List<Message> GetDeleted();
    }
}

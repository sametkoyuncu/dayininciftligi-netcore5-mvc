using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.EmailServices
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string Email, string Subject, string htmlMessage);
    }
}

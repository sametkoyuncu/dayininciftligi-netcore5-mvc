using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Entities;
using DayininCiftligiNetCore5.Interfaces;
using DayininCiftligiNetCore5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public Contact GetFirstVisible()
        {
            using var context = new DayiDbContext();

            return context.Contacts
                .Where(c => c.IsVisible == true)
                .FirstOrDefault();
        }

        public FooterModel GetFooterContactInfos()
        {
            using var context = new DayiDbContext();

            return context.Contacts
                .Where(c => c.IsVisible == true)
                .Select(c => new FooterModel()
                {
                    Address = c.Address,
                    City = c.City,
                    Phone = c.Phone,
                    Email = c.Email
                })
                .FirstOrDefault();
        }
    }
}

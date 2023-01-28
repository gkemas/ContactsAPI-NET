using ContactsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Data
{
    public class ContactsAPIDbContex : DbContext //ContactAPIDbContex e ctrl. ile alttaki options oluştu kısayol.
    {
        public ContactsAPIDbContex(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact>Contacts { get; set; }
    }
}

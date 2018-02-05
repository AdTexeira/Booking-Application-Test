using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResortBookingApp;

namespace ResortBookingApp.Models
{
    public class BookingsContext : DbContext
    {
        public BookingsContext (DbContextOptions<BookingsContext> options)
            : base(options)
        {
        }

        public DbSet<ResortBookingApp.Bookings> Bookings { get; set; }
    }
}

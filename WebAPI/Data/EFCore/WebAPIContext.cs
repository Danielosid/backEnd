using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext (DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI.Models.Book> Book { get; set; }

        public DbSet<WebAPI.Models.Client> Client { get; set; }

        public DbSet<WebAPI.Models.Contact> Contact { get; set; }

        public DbSet<WebAPI.Models.Genre> Genre { get; set; }

        public DbSet<WebAPI.Models.Orders> Orders { get; set; }
    }
}

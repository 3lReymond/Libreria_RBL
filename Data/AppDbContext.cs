using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using libreria_RBL.Data.Models;
using libreria_RBL.Data.Models;
using System.Collections.Generic;

namespace libreriaa_MALH.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<Book> Books { get; set; }
    }
}

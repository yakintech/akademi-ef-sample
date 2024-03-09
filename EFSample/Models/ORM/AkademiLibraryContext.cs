using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Models.ORM
{
    public class AkademiLibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-EET2RGT;Database=AkademiDb;trusted_connection=true;TrustServerCertificate=true");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}

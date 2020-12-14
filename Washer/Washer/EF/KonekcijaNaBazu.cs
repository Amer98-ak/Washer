using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Washer.Models;

namespace Washer.EF
{
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu() : base("Putanja")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Korisnici> Korisnici { get; set; }
        public DbSet<Rezervacije> Rezervacije { get; set; }
        public DbSet<Admin> Admin { get; set; }
    }
}

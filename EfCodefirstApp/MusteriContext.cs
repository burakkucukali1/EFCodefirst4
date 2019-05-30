using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodefirstApp
{
    public class MusteriContext : DbContext
    {
        public MusteriContext():base("sergenYalcin")
        {
            Database.SetInitializer(new CRMDBInitializer());
        }
       
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Adresler> Adres { get; set; }
        public DbSet<il> iller { get; set; }
    }
}

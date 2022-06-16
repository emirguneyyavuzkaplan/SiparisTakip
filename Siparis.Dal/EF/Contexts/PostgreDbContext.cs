using Microsoft.EntityFrameworkCore;
using Siparis.Dal.EF.Configuraiton;
using Siparis.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Dal.EF.Contexts
{
    public class PostgreDbContext:DbContext
    {

        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategory> Kategoriler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<SiparisMaster> Siparisler { get; set; }
        //Datebase de olusacak alan
        public int SiparisMasterId { get; set; }

        public DbSet<SiparisMaster> SiparisMaster { get; set; }
        public DbSet<SiparisDetay> SiparisDetay { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(@"server=127.0.0.1;Database=SiparisYönetimi;User Id =postgres; password = 123123;");

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new KategoriConfiguration());
            modelBuilder.ApplyConfiguration(new MusteriConfiguration());

           
        }
    }
}

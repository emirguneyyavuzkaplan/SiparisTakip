using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Siparis.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Dal.EF.Configuraiton
{
    internal class KategoriConfiguration : IEntityTypeConfiguration<Kategory>
    {
        public void Configure(EntityTypeBuilder<Kategory> builder)
        {
          builder.Property(p=>p.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(p => p.Aciklama).HasMaxLength(100).IsRequired(true);
            

            builder.HasData(new Kategory
            { Id = 1, KategoriKodu = "001", Name = "Elektronik", Aciklama = "Elektronik", _createDate = DateTime.Now },
               new Kategory { Id = 2, KategoriKodu = "002", Name = "Bilsayar", Aciklama = "Bilsayar", _createDate = DateTime.Now },
                new Kategory { Id = 3, KategoriKodu = "003", Name = "CepTelefonu", Aciklama = "Ceptelefonu", _createDate = DateTime.Now },
                new Kategory { Id = 4, KategoriKodu = "004", Name = "Beyaz Eyşa", Aciklama = "Beyaz Eyşa", _createDate = DateTime.Now });


        }
    }
}

using Siparis.Entitiy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entitiy.Concrete
{
    public  class Urun:BaseEntity
    {
        public string UrunKodu { get; set; }
        public int KategoryId { get; set; }
        public Kategory Kategori { get; set; }
    }
}

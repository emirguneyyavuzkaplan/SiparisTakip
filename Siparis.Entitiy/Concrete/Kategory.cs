using Siparis.Entitiy.Abstract;

namespace Siparis.Entitiy.Concrete
{
    public class Kategory:BaseEntity
    {
        public string KategoriKodu { get; set; }
        public string Aciklama { get; set; }

        public IList<Urun> Urunler { get; set; }
        
    }
}
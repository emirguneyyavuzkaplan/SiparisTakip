using Siparis.Entitiy.Abstract;

namespace Siparis.Entitiy.Concrete
{
    public class SiparisDetay:BaseEntity
    {
        public int UrunId { get; set; }
        public Urun Urun { get; set; } 
        public decimal Fİyat { get; set; }
        public decimal Adet { get; set; }
        public decimal Indirim { get; set; } = 0;


    }
}
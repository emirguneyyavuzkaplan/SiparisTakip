using Siparis.Entitiy.Abstract;

namespace Siparis.Entitiy.Concrete
{
    public class Personel:BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public ICollection<SiparisMaster> Siparisler { get; set; }

    }
}
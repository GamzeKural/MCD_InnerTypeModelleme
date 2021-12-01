using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InnerTypeModelleme
{
    public class Musteri
    {
        #region Tekil Olarak Kullanılan özellikler(Property)
        public int MusteriId { get; set; }
        public string TcKimlikNumarasi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public int KullaniciId { get; set; }
        #endregion

        #region Inner Type gerektiren alanlar(field)
        public MusteriAdres[] musteriAdresleri;
        public MusteriIletisimBilgisi[] musteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;

        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[5];
            musteriIletisimBilgileri = new MusteriIletisimBilgisi[3];
            musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
        }


        #endregion


    }
}

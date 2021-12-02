using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.MusteriId = 1;
            M1.TcKimlikNumarasi = "18893437834";
            M1.Isim = "Gamze";
            M1.Soyisim = "Kural";
            M1.OlusturmaTarihi = DateTime.Now;

            //M1.musteriAdresleri = new MusteriAdres[5];
            //Asla yapmayın...

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                Il = "İstanbul",
                Ilce = "Kadıköy",
                Adres="Adres...",
                AdresTip="İş yeri"
            };

            M1.musteriAdresleri[0].MusteriAdresTestMetot();
            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi="SIP0001"
            };

            M1.musteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                UrunId = 1,
                Tanim="Telefon",
                Fiyat=1500
            };

            M1.musteriSiparisBilgileri[0].urunler[1] = new Urun()
            {
                UrunId = 2,
                Tanim = "Tablet",
                Fiyat = 2500
            };

            foreach (Urun item in M1.musteriSiparisBilgileri[0].urunler)
            {
                Console.WriteLine("id: " + item.UrunId + " " + "tanim:" + item.Tanim + " " + "fiyat: " + item.Fiyat);
            }

            Console.ReadKey();
        }
    }
}

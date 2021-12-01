using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InnerTypeModelleme
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string Tanim { get; set; }
        public decimal Fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Urun Yapıcı Metot Çalıştı.");
        }

        public void UrunTestMetot()
        {
            Console.WriteLine("UrunTestMetot");
        }
    }
}

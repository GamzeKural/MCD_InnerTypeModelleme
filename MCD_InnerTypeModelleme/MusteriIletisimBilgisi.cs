using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InnerTypeModelleme
{
    public class MusteriIletisimBilgisi
    {
        public int IletisimTip { get; set; } //717770001:Mobil - 717770002:Sabit Hat
        public string AlanKodu { get; set; }
        public string Numara { get; set; }
        public bool AktifPasif { get; set; }

        public void MusteriIletisimBilgisiTestMetot()
        {
            Console.WriteLine("Müşteri İletişim Test Metot");
        }

    }
}

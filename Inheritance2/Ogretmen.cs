using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class Ogretmen: BaseKisi
    {
        public int MaasBilgisi {  get; set; }
        //Ogretmen için ilave metotlar -> Konsol ekranına Maaş bilgisi, ad ve soyad yazdıran bir metot.
        public void OgretmenMaas()
        {
            Console.WriteLine("Maas Bilgisi: " + MaasBilgisi);
        }
    }
}

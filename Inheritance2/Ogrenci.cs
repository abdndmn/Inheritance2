using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class Ogrenci:BaseKisi
    {
        public int OgrenciNo {  get; set; }
        //Ogrenci için ilave metotlar -> Konsol ekranına öğrenci numarası, ad ve soyad yazdıran bir metot
        public void OgrenciNumber()
        {
            Console.WriteLine("Ogrenci Numarası: " +OgrenciNo);
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class BaseKisi
    {
        public string Ad {  get; set; }
        public string Soyad { get; set; }

        public void AdSoyad()
        {
            Console.WriteLine("\nAdı: "+Ad+"\nSoyadı: "+Soyad);
        }

    }
}

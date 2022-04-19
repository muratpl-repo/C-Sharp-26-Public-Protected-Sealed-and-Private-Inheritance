using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69DersProtectedSealedErisimleri
{
    class Program
    {


        //sealed class Kisiler //(Sealed:Muhurlu/Gizli/Kapali) (Class'i sealed yapinca hic bi sekilde baska siniflardan miras alinamaz...)
        class Kisiler //Base Class : Temel sinif (Miras alinan sinif)
        {
            protected string Isim { get; set; } //Protected: Korunmus (Protected olunca sadece miras alinan siniftan ulasilabilir.
        }                                       //Private olsaydi hic bi sekilde ulasilamazdi...)
        class Ogrenci:Kisiler //Derived Class : Turemis sinif (Miras alan sinif)
        {
            public Ogrenci(string i)
            {
                Isim = i;
            }
            public string isimSoyle()
            {
                return Isim;
            }

        }

        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci("Murat");
            Console.WriteLine(o1.isimSoyle());
        }
    }
}

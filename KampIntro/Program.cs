using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety:tip guvenligi
            string kategoriEtiketi = "Kategori"; //deger tutucu. Metnin takma ismi(alias)

            int ogrenciSayısı = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDun<dolarBugun) 
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarlari Butonu ");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}

//degiskenler veri tutuculardır. Veriyi degiskenler ile yönetiriz.
//noktalivirgul, satirin bittigini belirtir.
//do not repeat yourself:kendini tekrarlama.
//if'de sart gecerliyse blok calissin. kisa yol if için, if yazip iki defa tab'a basiliyor.
//


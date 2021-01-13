using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi

            string[] kurslar = new string[] {"Yazlım geliştirici kampı","programlamaya başlangıc kampi","Java","python","C#" }; //birden fazla string tutma

            //gercekhayatta : string[] kurslar=kurslarigetir();

            for (int i = 0; i <kurslar.Length; i++) //i+=2 //i'yi sıfırdan baslat, kurslar dizisinin uzunlugu kadar i'yi bir arttır.
            {               
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar) //kurslar icinde dolas
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
//Döngüleri biribirine benzeyen islemleri tekrar etmek icin kullaniriz.
//Tek tek tanımlamak yerine arrayda tutmak daha dinamik.
//çogunlukla programlama dilleri saymaya sfırdan baslar
//foreach, dizi temelli yapıları tek tek dönmeye yarar.
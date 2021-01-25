using System;

namespace Donguler_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım gelistricii yetistirtme kmapi";
            string kurs2 = "Programlaaya baslangic icin temel kurs";

            //array-dizi
            string[] kurslar = new string[] { "Yazılım gelistricii yetistirtme kmapi" , "Programlaaya baslangic icin temel kurs" };



            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            foreach( string kurs  in kurslar ) //foreach dizilere uygulanır.
            {
                Console.WriteLine(kurs);
            }

        }
    }
}

using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "yilmo";
            int yas = 21;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin demiorog";
            kurs1.IzlenmeOrani = "68";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "engin demiorog";
            kurs2.IzlenmeOrani = "64";
            Console.WriteLine("Hello World!");

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "engin demiorog";
            kurs3.IzlenmeOrani = "80";

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
        
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string IzlenmeOrani { get; set; }


    }
}

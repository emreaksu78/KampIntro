using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Java", "C#", "Python", "HTML" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            string[] isimler = new string[] { "Ali", "Mehmet", "Veli", "Ayşe", "Merve" };

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }


            string[] oyunlar = new string[] { "futbol", "basketbol", "hentbol", "voleybol", "beyzbol" };

            for (int i = 0; i < oyunlar.Length; i++)
            {
                Console.WriteLine(oyunlar[i]);
            }





            Console.WriteLine("foreach bitti");

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            for (int i = 2; i < 7; i++)
            {
                if (i % 2 == 0)
                Console.WriteLine(i);

            }

            int x = 4;
            int y = 9;

            int max = x>y ? x : y;

            Console.WriteLine(max);

            int sayi = 1;
            while (true)
            {
                if (sayi == 11)
                {
                    break;
                }
                Console.WriteLine(sayi);
                sayi+=2;
            }

        }

    }
}

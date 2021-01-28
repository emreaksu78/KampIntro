using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            //sayilar1 in ilk elemanı sayilar2 nin ilk elemanına eşit olur. Yani 999.


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 40;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);

            //sayi1 20 olur. Çünkü sayi1 sayi2 ye eşitlendikten sonra, alt satırlarda yapılacak değişiklik sayi1 i etkilemez ama sayi 2 değişir. Sayi1 30 , sayi2 40 olur. Ama sayi2=40 satırı bir üstte olsaydı sayi1 ve sayi2 40 olurdu.

            //int, decimal, float, double, bool == DEĞER TİP  (sayısal görüntülüdürler.)

            //array, class, interface == REFERANS TİP. Arrayin[] türü önemli değil. int olur string olur farketmez.

            //engin demiroğ c# 3.dersin 2:30:00 da anlatıyor konuyu.


            int abc = 12;
            Console.WriteLine(abc == 10 ? "Number is 10" : "Number is not 10");

        }
    } 
}

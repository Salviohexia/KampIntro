using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999

            //int,decimal,float,double,bool = değer tip                  Stack:            Heap:
            //array, class, interface = referans tip                  101/sayilar 1 -----> 101/[10,20,30]
            //                                                        102/sayilar 2 -----> 102/[100,200,300]          sayilar1 = sayilar2, yaparsak sayilar1'in adresi 102 olur ve 101 heap anlamsız olur.
            //                                                                                                        sayilar2[0] = 999,  yapınca 102 heap'in ilk elemanı 999 olur.
            //                                                                                                        Böylece sayilar1[0] = 999 olur
        }
    }
}

using System;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            SelamVer("Faruk");
            SelamVer( );

            

            Console.Write("1. Sayıyı giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("2. Sayıyı giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());


            Topla(s1, s2);
            // Console.WriteLine("Hello World!");
        }


        static void  SelamVer(string isim="DefaultParametre")
        {
            Console.WriteLine("Merhaba  : "+ isim);
        }

        static int Topla(int sayi1 ,int sayi2)
        { 
            int sonuc=sayi1 + sayi2;
            Console.WriteLine("Toplam Sonuc : " + sonuc);
            return sonuc;
        }

     
    }
}

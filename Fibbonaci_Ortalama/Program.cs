using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derinlik Giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ilk " + number + " sayinin ortalamasi=" + Fonksiyonlarim.FibbonaciTopla(number));

            Console.ReadKey();

        }

        public static class Fonksiyonlarim
        {
            public static int FibonacciSiradakiSayiGetir(int derinlik)
            {
                int x1 = 1;
                int x2 = 1;
                int sonsayi = 0;


                if (derinlik >= 3)
                {
                    for (int i = 1; i <= derinlik - 2; i++)
                    {
                        sonsayi = x1 + x2;
                        x1 = x2;
                        x2 = sonsayi;
                    }
                }
                return x2;
            }
            public static double FibbonaciTopla(int derinlik)
            {
                double plus = 0;
                for (int i = 1; i <= derinlik; i++)
                {
                    plus = plus + FibonacciSiradakiSayiGetir(i);
                }
                return plus * 1.0 / derinlik;
            }
        }
    }
}

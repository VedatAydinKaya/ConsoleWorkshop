using System;

namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check();
            // Console.WriteLine("Hello World!");
        }

        internal static void Check()
        {
            /* Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
             * Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */

            int val1;
            int val2;

             Console.WriteLine("Pozitif 2 sayı giriniz:");          

                while (true)
                {
                    Console.Write("1.sayınızı giriniz: ");
                   val1 = Convert.ToInt32(Console.ReadLine());
                    if (val1 <= 0)
                    {
                        Console.WriteLine(" Negatif sayı girdiniz Lutfen 1. pozitif sayınızı  giriniz:");
                        continue;

                    }
                    else
                    {
                        Console.WriteLine("1.girilen pozitif sayınız: "+val1);
                       break;     
                      
                    }
                }

            while (true)
            {
                Console.Write("2.sayınızı giriniz: ");
                val2 = Convert.ToInt32(Console.ReadLine());
                if (val2 <= 0)
                {
                    Console.WriteLine(" Negatif sayı girdiniz Lutfen 2. pozitif sayınızı  giriniz:");
                    continue;

                }
                else
                {
                    Console.WriteLine($" 2.girilen pozitif sayınız: "+ val2);
                    break;

                }
            }
            Console.Write($"{val1} tane pozitif sayı giriniz");

            for (int i = 1; i <= val1; i++)
            {
                int deger;
                Console.Write($"{i}.pozitif sayı:");
                deger = Convert.ToInt32(Console.ReadLine());                
                if (val2 % deger==0)
                {
                    Console.WriteLine($"{val2} 'ye Tam bölünen  sayınız: "+deger);
                }
            }

           









        }
    }
}

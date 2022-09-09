using System;

namespace Odev1
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Chechk1();
            Check2();
           // Console.WriteLine("Hello World!");
        }
        public static void Chechk1() 
        {
            /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
             * Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */

            int val;
            Console.Write("Pozitif bir sayı giriniz :");
            val = Convert.ToInt32(Console.ReadLine());
          
                if (val > 0)
                {
                    Console.WriteLine("Girmiş oldugunuz sayı: " + val);
                }
                else
                {
                while (true)
                {
                    Console.WriteLine("Girilen sayı 0 dan buyuk değildir");
                  //  Console.Clear();
                    Console.Write("Pozitif bir sayı giriniz :");
                    val = Convert.ToInt32(Console.ReadLine());
                    if (val<=0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Girilen sayı:"+val);
                        break;
                    }

                }

            } 

        }

        public static void Check2() 
        {
           /* Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
             Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */

            int enteredCount;
            int val;

            Console.Write("Kaç tane pozitif sayı gireceksiniz :");
            enteredCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{enteredCount} girdiniz");

            for (int i = 1; i <= enteredCount; i++)
            {
              
                while (true)
                {
                    Console.Write($"{i}. sayınızı giriniz: ");
                    val = Convert.ToInt32(Console.ReadLine());
                    if (val <= 0)
                    {
                        Console.WriteLine("Lutfen pozitif sayı giriniz :");
                        continue;
                    }
                    else
                    {
                        if (val%2==0)
                        {
                            Console.WriteLine($"Çift sayınız  : {val}");

                        }                     
                        break;
                    }
                }           
                
            }

        
        }
    }
}

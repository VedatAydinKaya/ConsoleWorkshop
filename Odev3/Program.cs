using System;
using System.Collections.Generic;

namespace Odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check();
        }
        internal static void Check() 
        {
            /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
             * Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
             * Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */       

            string word;

            int val;
            while (true)
            {
                Console.Write("Pozitif tam sayı giriniz:");
                val = Convert.ToInt32(Console.ReadLine());
                if (val<=0)
                {
                    Console.WriteLine("Negatif sayı girdiniz:");
                    continue;
                }
                else
                {
                    string[] arrr=new string[val];
                    for (int i = 1; i <= val; i++)
                    {
                        Console.Write($"{i}.Kelimenizi giriniz: ");
                        word = Console.ReadLine();
                        arrr[i-1] = word;
                        //allWords.Add(word);
                        //word = "";
                     }
                     Array.Reverse(arrr);

                    Console.Write("Reversed entered words: ");
                    foreach (var item in arrr)
                    {
                        Console.Write($"{item} ");
                    }
                    break;
                }
               
            }
            


        }
    }
}

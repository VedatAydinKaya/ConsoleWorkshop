using System;

namespace Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check();
        }
        internal  static void Check() 
        {
            /*  Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
             *  Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */
         
            while (true)
            {
             
                Console.Write("Lutfen bir cumle bir yazın :");
                string sentence;
                sentence = Console.ReadLine();
                if (sentence.Length<10)
                {
                    Console.WriteLine("Lutfen daha uzun bir cumle giriniiz: ");
                    continue;
                }
                else
                {
                    int totalLetterRemovedFromSpace = 0;
                    string[] result = sentence.Split(' ');               
                    foreach (var item in result)
                    {
                        totalLetterRemovedFromSpace += item.Length;
                    } 
                    Console.WriteLine("Total Words: " + result.Length);
                    Console.WriteLine($"Total letter: {totalLetterRemovedFromSpace} ");

                    break;
                }
            }
        }
    }
}

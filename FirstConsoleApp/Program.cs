

using System;

namespace FirstConsoleAp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name;
            string surname;
            Console.WriteLine("Hello World!");
            /* Console.WriteLine("Hey programmer");
              Console.BackgroundColor = ConsoleColor.Yellow;
              Console.BackgroundColor = ConsoleColor.Red;
                Console.ReadLine();  */

            Console.Write("Adınızı giriniz:");
            name = Console.ReadLine();
            Console.Write("Soyadınızı giriniz:");
            surname = Console.ReadLine();

            Console.WriteLine("Merhaba: "+name+" "+surname);
        }
    }
}

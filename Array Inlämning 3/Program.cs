using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal ska du skriva");
            int tal = int.Parse(Console.ReadLine());
            string[] talen = new string[tal];

            for (int i = 0; i < tal; i++)
            {
                Console.WriteLine("Skriv in talen");
                talen[i] = Console.ReadLine();
            }
            Console.WriteLine("Här är talen du skrev");
            for (int i = 0; i < tal; i++)
            {
                Console.WriteLine(talen[i]);
            }
        }
    }
}

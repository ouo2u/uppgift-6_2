using System;

namespace upggift6_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in vad tal1 ska bli");
          
           int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("skriv in vad tal2 ska bli");
          
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"det störta talet blir: {störst(tal1,tal2)}");

        }
        static int störst(int tal1, int tal2)
        {
          
            if (tal1 == tal2)
            {
                return tal1;
            }
            else if (tal2 > tal1)
            {
                return tal2;
            }
            else
            {
                return tal1;
            }
        }
    }
}

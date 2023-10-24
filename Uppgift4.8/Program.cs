using System;
namespace Uppgift_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett med ord");
            string ord = Console.ReadLine();
            string bokstäver = "ab";
            bool första = false;
            bool andra = false;
            for (int i = 0; i < ord.Length; i++)
            {
                if (ord[i] == bokstäver[0])
                {
                    första = true;
                }
                else if (ord[i] == bokstäver[1])
                {
                    andra = true;
                }
            }
            if(första)
            {
                Console.WriteLine(bokstäver[0] + " Finns i ordet");
            }
            if(andra)
            {
                Console.WriteLine(bokstäver[1] + " Finns i ordet");
            }
            if(första == false && andra == false)
            {
                Console.WriteLine("Inga av bokstäverna finns i ordet ");
            }
        Console.ReadKey();
        }
    }
}
using System;
namespace Uppgift_3_14_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du klarat av gymnasiet?");
            string svar = Console.ReadLine().ToLower();


            if (svar == "j")
            {
                Console.WriteLine("Hur gammal är du?");
                int ålder = int.Parse(Console.ReadLine());

            if (ålder <= 22 && ålder >= 18)
                {
                    Console.WriteLine("Vi vill anställa dig");

                }

                else
                {
                    Console.WriteLine("Vi är tyvärr inte intresserade");
                }
                

            }

            else if (svar == "n")
            {
                Console.WriteLine("Nej tack");
            }
        }
    }
}
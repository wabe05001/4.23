using System;

namespace övning_4._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett heltal");

            int tal = int.Parse(Console.ReadLine());

            int störst = tal;

            string svar = "";
            while (svar != "n")
            {
                Console.WriteLine("Vill du skriva in ett till heltal? (j/n");
                svar = Console.ReadLine();  

                if (svar == "n")
                {
                    break;
                }
                Console.WriteLine("skriv in ett heltal till");
                int nytttal=int.Parse(Console.ReadLine());

                {
                    if (nytttal > störst) 
                    störst = nytttal;
                }

                Console.WriteLine($"Det största talet var(störst)");
            }



        }
    }


}
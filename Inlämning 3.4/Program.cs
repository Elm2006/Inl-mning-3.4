using System;
namespace Inlämning_3.__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten skriv (minuter sekunder) på det sätter");
            string låt= Console.ReadLine();
            int mellanslag = låt.IndexOf(" ");
            int minut = int.Parse(låt[(..mellanslag)]);
            int sekunder = int.Parse(låt[((mellanslag+1)..)]);
            switch(minut)
            {
                case 2:
                    if (sekunder >= 45)
                    {
                        Console.WriteLine("Låten får spelas på radion");
                    }
                    else
                    {
                        Console.WriteLine("Låten får inte spelass på radion");
                    }
                    break;
                case 3:
                    Console.WriteLine("Låten får spelas på radion");
                    break;
                case 4:
                    if (sekunder <= 20)
                    {
                        Console.WriteLine("Låten får spelas på radion");
                    }
                    else
                    {
                        Console.WriteLine("Låten får inte spelas på radion");
                    }
                    break;
                default:
                    Console.WriteLine("Låten får inte spelas på radion");
                    break;
                

            }
            Console.ReadKey();
        }
    }
}

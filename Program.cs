using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaiciuotuvas
{
    class Menu
    {
        static void Main(string[] args)
        {
            float num1 = 0; float num2 = 0;
            Console.WriteLine("Skaiciuotuvas");
            Console.WriteLine("------------------------");
            Console.WriteLine("Patikslinkite is kiek skaitmenu bus atliekami veiksmai: [1] - is dvieju, [2] - is vieno");
            int Opt = Convert.ToInt32(Console.ReadLine());
            if (Opt == 1)
            {
                Console.WriteLine("Iveskite pirmaji skaiciu");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Iveskite antraji skaiciu");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pasirinkite is galimu variantu:");
                Console.WriteLine("\ta - Sudetis");
                Console.WriteLine("\tb - Atimtis");
                Console.WriteLine("\tc - Daugyba");
                Console.WriteLine("\td - Dalyba");
                Console.Write("Pasirinkite veiksma: ");

                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Atsakymas: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "b":
                        Console.WriteLine($"Atsakymas: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "c":
                        Console.WriteLine($"Atsakymas: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        while (num2 * num1 == 0)
                        {
                            Console.WriteLine("Dalyba is nulio negalima, iveskite kita skaiciu: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine($"Atsakymas: {num1} / {num2} = " + (num1 / num2));
                        break;
                }
            }
            if (Opt == 2)
            {
                Console.WriteLine("Parasykite skaiciu ir spauskite Enter");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\te - Kelimas kvadratu is pirmo skaiciaus");
                Console.WriteLine("\tg - Saknies traukimas is pirmo skaiciaus");
                Console.Write("Jusu pasirinkimas? ");

                switch (Console.ReadLine())
                {
                    case "e":
                        Console.WriteLine($"Atsakymas:  {num1} kvadratu = " + (num1 * num1));
                        break;
                    case "g":
                        Console.WriteLine($"Atsakymas: saknis is {num1} = " + Math.Sqrt(num1));
                        break;
                }
            }
            Console.Write("Paspauskite bent kuri mygtuka, kad isjungtumete programa...");
            Console.ReadKey();
        }
    }
}
using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            Console.WriteLine("Enter the first number");
            input = Console.ReadLine();
            int x = Convert.ToInt32(input);
            Console.WriteLine("Enter the second number");
            input = Console.ReadLine();
            int y = Convert.ToInt32(input);
            int rezultat = 0;
            Console.WriteLine("Vnesete eden od ponudenite znaci: +; -; *; /");
            string operacija = Console.ReadLine();
                if (operacija != "")
                {
                    switch (operacija)
                    {
                        case "+":
                            Console.WriteLine("Izbravte sobiranje");
                            rezultat = x + y;
                            Console.WriteLine("Rezultatot e " + rezultat);
                            break;
                        case "-":
                            Console.WriteLine("Izbravte sobiranje");
                            rezultat = x - y;
                            Console.WriteLine("Rezultatot e " + rezultat);
                            break;
                        case "*":
                            Console.WriteLine("Izbravte mnozenje");
                            rezultat = x * y;
                            Console.WriteLine("Rezultatot e " + rezultat);
                            break;
                        case "/":
                            Console.WriteLine("Izbravte delenje");
                            rezultat = x / y;
                            Console.WriteLine("Rezultatot e " + rezultat);
                            break;
                    }
                }
            else
            {
                Console.WriteLine("Vnesovte netocen znak!");
            }
        }
    }
}

using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Privremen;
            string input = String.Empty;
            Console.WriteLine("Vnesi go prviot broj.");
            input = Console.ReadLine();
            int PrvBr = Convert.ToInt32(input);
            Console.WriteLine("Vnesi go vtoriot broj.");
            input = Console.ReadLine();
            int VtorBr = Convert.ToInt32(input);
            Privremen = PrvBr;
            Console.WriteLine("Privremeniot broj go zavzema brojot prv vnesen " + Privremen);
            PrvBr = VtorBr;
            Console.WriteLine("Prviot broj go zavzema brojot kako vtor vnesen " + VtorBr);
            VtorBr = Privremen;
            Console.WriteLine("Vtoriot Broj go zavzema brojot na privremeniot " + Privremen);
        }
    }
}

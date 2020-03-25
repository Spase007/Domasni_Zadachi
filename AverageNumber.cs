using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            int AvgNum = 0;
                        Console.WriteLine("Ve molam vnesete go prviot broj.");
                        input = Console.ReadLine();
                        int PrvBr = Convert.ToInt32(input);
                        Console.WriteLine("Ve molam vnesete go vtoriot broj.");
                        input = Console.ReadLine();
                        int VtorBr = Convert.ToInt32(input);
                        Console.WriteLine("Ve molam vnesete go tretiot broj.");
                        input = Console.ReadLine();
                        int TretBr = Convert.ToInt32(input);
                        Console.WriteLine("Ve molam vnesete go cetvrtiot broj.");
                        input = Console.ReadLine();
                        int CetvrtBr = Convert.ToInt32(input);
                        AvgNum = (PrvBr + VtorBr + TretBr + CetvrtBr) / 4;
                        Console.WriteLine("Prosecnata vrednost e " + AvgNum);

        }
    }
}

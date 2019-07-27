using System;

namespace TestUnitarios
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsolaController mgr = new ConsolaController();
            Console.WriteLine(mgr.Salute());
        }
    }
}

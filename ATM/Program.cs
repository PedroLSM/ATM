using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa atm = new Caixa();

            Console.WriteLine(atm.Sacar(230));
            Console.WriteLine("===========================");
            
            Console.WriteLine(atm.Sacar(239));
            Console.WriteLine("===========================");

            Console.ReadKey();

        }
    }
}

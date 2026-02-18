using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     class TestComplex
    {
        private const double Epsilon = 1E-6;

        public static void Test(Complex skutecna, Complex ocekavana, string nazevTestu)
        {
            double rozdilReal = Math.Abs(skutecna.Real - ocekavana.Real);
            double rozdilImag = Math.Abs(skutecna.Imagine - ocekavana.Imagine);

            if (rozdilReal < Epsilon && rozdilImag < Epsilon)
            {
                Console.WriteLine($"{nazevTestu}: OK");
            }
            else
            {
                Console.WriteLine($"{nazevTestu}: Chyba");
                Console.WriteLine($"Očekávaná hodnota: {ocekavana}");
                Console.WriteLine($"Skutečná hodnota: {skutecna}");
            }
        }
    }


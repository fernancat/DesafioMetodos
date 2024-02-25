using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            calculator instanciaCalculadora = new calculator();

            Console.WriteLine(instanciaCalculadora.sumar(1,2));
            Console.WriteLine(instanciaCalculadora.resta(1,2));
            Console.WriteLine(instanciaCalculadora.multiplicar(1,2));
            Console.WriteLine(instanciaCalculadora.divison(1,2));


            Console.ReadKey(true);
        }


        class calculator
        {
            public int sumar(int num1, int num2)
            {
                return num1 + num2;
            }
            public int resta(int num1, int num2)
            {
                return num1 - num2;
            }
            public int multiplicar(int num1, int num2)
            {
                return num1 - num2;
            }
            public int divison(int num1, int num2)
            {
                return num1 / num2;
            }

        }

       
    }
}

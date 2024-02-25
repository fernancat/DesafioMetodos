using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace desafioTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingresa el primer valor: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el segundo valor: ");
                int num2 = int.Parse(Console.ReadLine());

                sumaValores(num1, num2);
                Console.ReadKey();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Ingresaste un espacio en blanco, o cualquiera de los dos numeros es un string");
                Console.ReadKey();

            }
           

        }


       static void sumaValores(int num1, int num2)
        {
            Console.WriteLine("La suma de los valores es: " + (num1+num2) );
        }
    }
}

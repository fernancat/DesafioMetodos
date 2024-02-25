using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMetodos
{
    internal class Program
    {
      
        static void Main(string[] args)
        {



            calcularIngresos(12000,1300.14,10000,"fernan");
            Console.ReadKey();
        }


        static void calcularIngresos(double mes, double mesDos , double mesTres, string nombreUsuario)
        {
            double suma = mes + mesDos + mesTres;
            double promedio = suma / 3;

            Console.WriteLine("Hola {0} en total ganaste {1} y promediaste {2} ",nombreUsuario,suma,promedio);
        }
       

    }
}

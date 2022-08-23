using EjercicioVectorNumerico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            VectorNumerico vectorNumerico = new VectorNumerico();

            if (vectorNumerico.Validar())
            {
               vectorNumerico.MostrarContenido();
                Console.WriteLine(vectorNumerico.ToString());
                Console.WriteLine(vectorNumerico.MostrarEnLinea());
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadLine();
        }
    }
}

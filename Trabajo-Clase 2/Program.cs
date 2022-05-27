using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Número;
            double Resultado;
            try
            { 
                Console.Write("\nEscriba un numero entero: ");
                Número = Int32.Parse(Console.ReadLine());

                Resultado = Math.Pow(Número, 2);

                Console.WriteLine("\nEl resultado es: {0}", Resultado);
                Console.Write("\nPresione ''ENTER'' para continuar...");

                Console.ReadKey();
            }
            catch (FormatException f)
            {
                Console.WriteLine("\nTipo de Error: " + f.Message);
                Console.WriteLine("\nUbicacion del Error: " + f.StackTrace);
                Console.Write("\nPresione ''ENTER'' para continuar..."); 

                Console.ReadKey();
            }
            catch (OverflowException o)
            {
                Console.WriteLine("\n Tipo de Error: " + o.Message);
                Console.WriteLine("\n Ubicacion del Error: " + o.StackTrace);
                Console.WriteLine("\n Presione ''ENTER'' para continuar... "); 

                Console.ReadKey();

            }
            finally
            {
                Console.WriteLine("\n\nEl bloque finally siempre se ejecuta.");
                Console.Write("\nPresione ''ENTER'' para salir..."); 

                Console.ReadKey();
            }
        }
    }
}

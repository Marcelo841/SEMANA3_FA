using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3___FA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer5();
            Console.ReadKey();
        }

        static void ejer1 ()
        {
            string carrera, nombre;
            Console.Write("Ingrese su nombre ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su carrera ");
            carrera = Console.ReadLine();
            Console.WriteLine($"\n{nombre}, bienvenido al curso de fundamentos de algoritmos de la carrera {carrera}");
        }
        static void ejer2()
        {
            Console.WriteLine("\"Marcelo\"");
        }
        static void ejer3()
        {
            
            int num1, num2;
            Console.Write("Ingrese el primer numero entero ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero entero ");
            num2 = int.Parse(Console.ReadLine());
            double divi = (double)num1 / (double)num2;
            Console.WriteLine("Suma: " +(num1+num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicacion: " + (num1 * num2));
            Console.WriteLine("Division: " + divi);

        }
        static void ejer4()
        {
            Console.Write("Ingrese un numero decimal: ");
            double num =double.Parse(Console.ReadLine());

            double raiz = Math.Sqrt(num);
            double redo = Math.Round(num,2);
            double cubo = Math.Pow(num,3);
            double cubica = Math.Pow(num, 1/3);

            Console.WriteLine("\nRaiz cuadrada: " + raiz);
            Console.WriteLine("Redondeado: " + redo);
            Console.WriteLine("Elevado a 3: " + cubo);
            Console.WriteLine("Raiz cubica: " + cubica);
        }
        static void ejer5()
        {
            Console.WriteLine("Ingrese un numero: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("Resto: " +(entero)
        }

        static void ejer6()
        {

        }
    }
}

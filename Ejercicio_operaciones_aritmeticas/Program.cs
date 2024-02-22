using System;

namespace Ejercicio_operaciones_aritmeticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            double cuadrado, raizcuadrada, raizcubica;

            Console.Write("Ingrese el primer número, a éste se le calcula el cuadrado: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Ingrese el segundo número. Para éste se calcula su raiz cuadrada:  ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Ingrese el tercer número. A éste se le calcula la raíz cubica:  ");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            cuadrado = num1 * num1;
            raizcuadrada = Math.Sqrt(num2);
            raizcubica = Math.Pow(num3, 1.0 / 3.0);

            Console.WriteLine("Cuadrado: " + num1 + " * " + num1 + " = " + cuadrado);
            Console.WriteLine("La raíz cuadrada de {0} es {1}", num2, raizcuadrada);
            Console.WriteLine("La raíz cubica de {0} es {1}", num3, raizcubica);
        }
    }
}

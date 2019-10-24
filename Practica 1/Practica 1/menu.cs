using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_1
{
    class menu
    {
            public static void ejercicio()
        {
            int a, b;
            Console.WriteLine("Ingrese el primer número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int sum, res;
                sum = a + b;
                res = a - b;
                Console.Write("El resultado de la suma es  " + sum);
                Console.WriteLine();
                Console.Write("El resultado de la resta es  " + res);

            }
            else
            {
                int mult;
                double div;
                mult = a * b;
                div = a / b;
                Console.Write("El resultado de la multiplicación es  " + mult);
                Console.WriteLine();
                Console.Write("El resultado de la división es  " + div);
            }
            Console.ReadKey();
        }
    }
}

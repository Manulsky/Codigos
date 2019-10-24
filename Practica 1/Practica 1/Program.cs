using System;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args) {

            int a;
            Console.WriteLine("Elije una de las siguientes opciones /n" +
                "1-Anotar dos numeros hasta que el segundo sea menor al primero");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    menu.ejercicio();
                    break;
                case 2:
                    Console.WriteLine("Esta en proceso");
                    break;
                case 3:

            }
        }
    }
}

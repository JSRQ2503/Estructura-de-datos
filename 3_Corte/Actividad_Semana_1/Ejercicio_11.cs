using System;
using System.Collections;

namespace Ejercicios
{
    class Program
    {
             
        static void Main(string[] args)
        {
            int Salida=0;
            Queue P = new Queue();
            while( Salida!=9)
            {
                Console.WriteLine("Ingrese un numero flotante:");
                double Num = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese 0 para agregar mas numeros");
                Console.WriteLine("Ingrese 9 para salir");
                Salida = int.Parse(Console.ReadLine());
                P.Enqueue(Num);
            }
                         
        
            Console.WriteLine("Los numeros de la lista son:");
            foreach (var n in P)
            {
                Console.Write($" {n} |");
            }
        }         
    }
}


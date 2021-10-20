using System;
using System.Collections;

namespace Ejercicios
{
    class Program
    {
             
       static void Main(string[] args)
        {
            Queue Numeros = new Queue();
            Random ale = new Random();
            Numeros.Enqueue(ale.Next(1,100));
            Numeros.Enqueue(ale.Next(1,100));
            Numeros.Enqueue(ale.Next(1,100));
            Numeros.Enqueue(ale.Next(1,100));
            Numeros.Enqueue(ale.Next(1,100));
            ArrayList Numero = new ArrayList(Numeros);
            
            Imprimirlista(Numeros);
            Console.WriteLine("Ingrese el numero");
            int numeros = int.Parse(Console.ReadLine());

            
            int numero = Numero.IndexOf(numeros);
            numero++;
            Console.WriteLine("El numero {0} se encuentra en la posicion {1}",numeros,numero);
            
        }
        static void Imprimirlista(Queue Lista)
        {
            Console.WriteLine("Los numeros de la lista es:");
            foreach (int n in Lista)
            {
                Console.WriteLine(n);
            }
        }        
    }
}


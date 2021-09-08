/*INTEGRANTES DEL GRUPO:
        Johan Sebastian Rios
        Luis Esteban Triana
        Juan Manuel Vanegas
        Andres Santiago Villamil 
  Jornada:
        Diurna
   Grupo:
        63102C / 239 - 2A */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Problema 3:Realiza un programa que lea 5 números y por cada número leído, 
/// mande a imprimir la cantidad en asteriscos, antes de leer el siguiente número.
namespace problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int q, w, e, r, t;
            Console.WriteLine("ingresa los numeros");
            Console.Write("Ingresa N# 1: ");
            q = Convert.ToInt32(Console.ReadLine());
            Console.Write("1. {0}: ", q);
            for (int i = 0; i < q; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("Ingresa N# 2: ");
            w = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. {0}: ", w);
            for (int i = 0; i < w; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("Ingresa N# 3: ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. {0}: ", e);
            for (int i = 0; i < e; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("Ingresa N# 4: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("4. {0}: ", r);
            for (int i = 0; i < r; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("Ingresa N# 5: ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("5. {0}: ", t);
            for (int i = 0; i < t; i++)
            {
                Console.Write("*");
            }
        }

    }
}
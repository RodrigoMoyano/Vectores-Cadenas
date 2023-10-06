using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio.
            //   Mostrar por pantalla los valores que son mayores al promedio.
            int acu = 0;
            int[] numeros = new int[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                numeros[x] = int.Parse(Console.ReadLine());
                acu += numeros[x];

              }int prom = 0;
             prom = acu / 10;
             Console.WriteLine("El promedio es: " + prom);
            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > prom){
                
                Console.WriteLine(+ numeros[x] + " es mayor al promedio.");
                }
            }

            


            Console.WriteLine("Hello World!");
        }
    }
}

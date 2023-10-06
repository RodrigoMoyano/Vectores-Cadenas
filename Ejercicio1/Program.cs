using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int[] numeros = new int[10];
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                numeros[x] = int.Parse(Console.ReadLine());
                 
            }
            int max = 0, pos = 1;
            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > max){
                max = numeros[x];
                pos = x + 1;}

                
            }
            Console.WriteLine("El nro maximo es: " + max + " en la posicion " + pos);
        }
    }
}

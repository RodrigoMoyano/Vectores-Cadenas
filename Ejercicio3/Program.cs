using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
            // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.
            // Mostrar el resultado en pantalla. Ejemplo:
                //CADENA FUENTE: “La mar estaba serena"
                //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
                //CADENA RESULTADO: “Li mir estibi sereni"

                char palabra, a, b;
                int i = 0;

                char[] cadena = new char [21];
                Console.WriteLine("Ingrese letra a remplazar: ");
                a = char.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese letra remplazante: ");
                b = char.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la palabra letra por letra: ");
                palabra = char.Parse(Console.ReadLine());

                while(palabra != '.' && i < 21){
                   
                    cadena[i] = palabra;
                    
                    if(cadena[i] == a)
                    cadena[i] = b;

                     
                    palabra = char.Parse(Console.ReadLine());
                    i++;
                    

                }
                cadena[i] = '\0';
                i = 0;
                while(cadena[i] != '\0'){

                Console.Write(cadena[i]);
                i++;
                }



            


                



            
        }
    }
}

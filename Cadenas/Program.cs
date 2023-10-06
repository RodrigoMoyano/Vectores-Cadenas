using System;

namespace Cademas
{
    class Program
    {
        static void Main(string[] args)
        {

            // CADENAS DE CARACTERES
            //char[] cadena = new char [10];

            //STRING
            //CADENA DE CARACTERES
            //VECTOR DE CHAR
            // PARA DIFERENCIAR UNA CADENA DE UN VECTOR DE CHAR
            //TENEMOS QUE SABER QUE UN VECTOR DE CHAR SIRVE
            //PARA CARGAR UNA LETRA POR INDICE,
            //EN UNA CADENA PUEDO CARGAR UNA FRASE COMPLETA
            //
            //BARRA CERO \0 (alt 192)
           // frase[5] = '\0';

            // |P|A|A|P|A| | | | | |P| | | | : VECTOR DE CHAR
            // H|O|L|A| |Q|U|E| |T|A|L|/0| | : CADENA

            //INT, FLOAT, BOOL. CHAR, STRING NO

            char[] nombre = new char[11];
            char letra;
            int indice = 0;
            //j = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su nombre letra por letra... (termina con punto)");
            letra = char.Parse(Console.ReadLine());
            while (letra != '.' && indice < 11)
            {
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }

                
            
           // if(indice == 10)
           // indice--;
            

            nombre[indice] = '\0';
            // |m|a|x|i|\0| | | |

            Console.WriteLine("Hola " + nombre);

            //Console.Write("Hola ");
            //indice = 0;

            //while(nombre[indice] != '\0')
            //{
            //    Console.Write(nombre[indice]);
            //    indice++
            //}

            // CON DATOS AVANZADOS

            //string nombre;
            //Console.WriteLine("Ingrese su nombre...");
            //nombre = Console.ReadLine();
            //Console.WriteLine("Hola " + nombre);






            
        }
    }
}

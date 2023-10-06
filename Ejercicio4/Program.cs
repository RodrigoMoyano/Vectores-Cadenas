using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 

            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.

            int NA, CV;

            int[] cantidadVendida = new int[15];

            Console.WriteLine("Ingrese el nro de articulo: ");
            NA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            CV = int.Parse(Console.ReadLine());

            for (int x = 0; x < 15; x++)
            {
                
                cantidadVendida[x] = 0;
                }
                
                while (NA != 0)
                {   
                    cantidadVendida[NA -1] += CV;
                    
                Console.WriteLine("Ingrese el nro de articulo: ");
                NA = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                CV = int.Parse(Console.ReadLine());

                }
                int max = cantidadVendida[0];
                for (int x = 0; x < 15; x++)
                {
                    if(cantidadVendida[x] > max){
                    max = cantidadVendida[x];
                    NA = x + 1;}
                }
                Console.WriteLine("C A mas vendido " + NA);

                for (int x = 0; x < 15; x++)
                {
                    if(cantidadVendida[x] == 0)
                    Console.WriteLine("Los articulos que no tuvieron ventas son:" + (x + 1));
                    
                    
                }
                Console.WriteLine("Se vendieron " + cantidadVendida[9] + " unidades del articulo 10");
                
                
                

                


            



            
        }
    }
}

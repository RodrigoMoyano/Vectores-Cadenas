using System;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            //VECTORES, ARRAY, ARREGLO
            //int n;
            //int[] numeros = new int [10];
            //  0 1 2 3 4 5 6 7 8 9
            // |7| | | | | |1| | |31541| 

            //for (int x = 0; x < 10; x++)
            //{
            //    Console.WriteLine("Ingrese la nota...");
            //    n = int.Parse(Console.ReadLine());
            //    numeros[x] = n;
                
            //}

            //int acu = 0;

            // for (int x = 0; x < 10; x++){

            //    acu += numeros[x];
            //    Console.WriteLine("El valor es: " + numeros[x]);
            // }
            // int prom = acu / 10
            

           // Console.WriteLine("Hello World!");
        
            //int (long, short)
            //float - double - decimal
            // 0 1 2 3 4 5....... 30
            // | | | ||| | | | | | |
            double[] muestraMatutina = new double[31];
            double[] muestraVespertina = new double[31];
            double[] muestraNocturna = new double[31];

            //cruce
            //registro matutino
            int dia;
            double temperatura;
            Console.WriteLine("Cargue el registro maturino: ");

            for (int x = 0; x < 31; x++)
            {
                Console.WriteLine("Ingrese el dia: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la temperatura: ");
                temperatura = double.Parse(Console.ReadLine());

                muestraMatutina[dia - 1] = temperatura;
                
            }
            for (int x = 0; x < 31; x++)
            {
                
            }
             for (int x = 0; x < 31; x++)
             {
                
             }

             //leer vectores
             // double acu = 0;
             //for (int x = 0; x < 31; x++)
             //{
             //  acu += muestraMatutina[x];
             //}

             // Con carga de sueldos y legajos, dond no podemos utilizar nro
             // de legajo como indice para cargar el sueldo, entonces se inicializan
             // los dos juntos donde se cargaran en el mismo indice. 
          

            // double[] sueldos = new double[50];
            //int[] legajo = new int[50];
            // for (int x = 0; x < 31; x++)
            // {
                
            //    sueldos[x] = 123;
            //    legajos[x] = 456;
                
            // }
            
            // VECTORES TIPO BOOL
             
              // int, float, bool, char
              
              // bool[] asistenciasQuincena1 = new bool[15] 
             // for (int x = 0; x < 15; x++)
             // {
                //dia
                //asistencia
             //   }

                int[] legajo = new bool[100];
                bool[] asistencia = new bool[100];
                //CARGO LAS ASISTENCIA DE LOS 16 DIAS CON 100 ALUMNOS
                for (int x = 0; x < 16; x++)
                {
                    for (int y = 0; y < 100; y++)
                    {
                        
                    }
                    
                }
              
                
               
                
            }
            
            
                
            }
        
        }

    
    }
}

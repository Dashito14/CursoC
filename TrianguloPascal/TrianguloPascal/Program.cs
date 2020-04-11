using System;

namespace TrianguloPascal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresa el número de pisos ");

            //Tiene que ser un numero entero, el ReadLine con un convertidor a int
            int pisos = Convert.ToInt16(Console.ReadLine());

            int[] array = new int[pisos];
            int[] arrayAnterior = new int[pisos];

            //Inicializamos a 0 los arrays
            for(int i = 0; i < pisos; i++)
            {
                array[i] = 0;
                arrayAnterior[i] = 0;
            }

            //Cada iteracion es un piso del triangulo
            for (int i = 1; i < pisos + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j != 0)
                    {
                        //Es la suma del valor de arriba mas el anterior al de arriba
                        array[j] = arrayAnterior[j] + arrayAnterior[j - 1];
                    }
                    else
                    {
                        //Si esta en la primera posicion sera 1
                        array[j] = 1;
                    }
                    Console.Write("[{0}]", array[j]);
                }
                Console.WriteLine("");

                //Hacemos que el arrayAnterior sea el resultado final del array actual
                for (int r = 0; r < pisos; r++) { 
                    arrayAnterior[r] = array[r];
                }

            }

            //system pause
            Console.ReadLine();
        }
    }
}

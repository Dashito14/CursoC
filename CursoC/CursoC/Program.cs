using System;

namespace CursoC
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 2020;
            int s = 2021;

            Console.WriteLine("Hola Mundo! Estamos en el año " + v + ". No llegaremos a " + s + '.');
            Console.WriteLine("Hola Mundo! Estamos en el año {0}. No llegaremos a {1}.", /*{0}*/v, /*{1}*/s);

            int x = Convert.ToInt16("2020"); //De String a Entero
            double d = 2.021; //Si el valor es 2.0 se imprime solo el 2 (obvio)

            Console.WriteLine("Hola Mundo! Estamos en el año {0}. No llegaremos a {1}.", /*{0}*/x, /*{1}*/d);

            string n = "Hola Mundo!";

            Console.WriteLine("{2} Estamos en el año {0}. No llegaremos a {1}.", /*{0}*/v, /*{1}*/s, /*{2}*/n);
            Console.WriteLine(n + " Estamos en el año {0}. No llegaremos a {1}.", /*{0}*/v, /*{1}*/s);

            decimal dec = 2.07M; //La M es para crear un literal con este valor del tipo decimal, para constantes
            float f = 2.07F; //La F es para crear el literal

            /*
             *float 7 dígitos - 32 bits
             *double 15-16 dígitos - 64 bits
             *decimal 28-29 dígitos - 128 bits
            */

            Console.WriteLine(dec + "" + f);

            bool bf = false;
            bool bt = true;

            char l = '.';

            if (!bf && bt)
            {
                Console.WriteLine("{2} Estamos en el año {0}{3} No llegaremos a {1}{3}", /*{0}*/v, /*{1}*/s, /*{2}*/n, /*{3}*/l);
            }

            /*------------------------------------------------------------------------------------------------------------------*/
            /*-------------------------------------------OPERADORES ARITMÉTICOS-------------------------------------------------*/
            /*------------------------------------------------------------------------------------------------------------------*/

            int valor1 = 2;
            int valor2 = 4;

            var suma = valor1 + valor2;  //Con var se puede crear cualquier tipo de objeto, cuando se el asigne algún dato tendrá su tipo
            var mult = valor1 * valor2;
            var resta = valor2 - valor1;
            var div = valor2 / valor1;

            Console.WriteLine(suma + " " + resta + " " + mult + " " + div);

            valor2 += valor1; //Cambia el valor2
            Console.WriteLine(valor2 + " es la suma de valor1 y valor2.");

            valor2 = 4;
            valor2 -= valor1;
            Console.WriteLine(valor2 + " es la resta de valor1 y valor2.");

            valor2 = 4;
            valor2 *= valor1;
            Console.WriteLine(valor2 + " es la multiplicacion de valor1 y valor2.");

            valor2 = 4;
            valor2 /= valor1;
            Console.WriteLine(valor2 + " es la division de valor1 y valor2.");

            valor2 = 4;
            valor2 %= valor1;
            Console.WriteLine(valor2 + " es el resto de dividir 4 entre 2.");


            /*------------------------------------------------------------------------------------------------------------------*/
            /*-------------------------------------------OPERADORES CONDICIONALES-----------------------------------------------*/
            /*------------------------------------------------------------------------------------------------------------------*/

            int v1 = 9;
            int v2 = 9;
            var data = v1 == v2;
            string nombre;

            /*
            if (data)
            {
                nombre = "Antonio";
            }
            else
            {
                nombre = "Rodrigo";
            }
            */

            //Lo comentado es lo mismo que la sentencia siguiente
            nombre = data ? "Antonio" : "Rodrigo";

            /*------------------------------------------------------------------------------------------------------------------*/
            /*-----------------------------------------------------ARRAYS-------------------------------------------------------*/
            /*------------------------------------------------------------------------------------------------------------------*/

            string[] cadenas = new string[3];
            cadenas[0] = "Pepe";
            cadenas[1] = "Marmoto";
            cadenas[2] = "Peluco";

            string[] nomb = { "Pepe", "Marmoto", "Peluco" }; //Los dos ejemplos son lo mismo

            /*------------------------------------------------------------------------------------------------------------------*/
            /*-----------------------------------------------------MATRICES-----------------------------------------------------*/
            /*------------------------------------------------------------------------------------------------------------------*/

            //Matriz de enteros de dos filas y tres columnas
            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //En un array tridimensional se pueden almacenar varios datos en una misma columna y fila
            //En este caso hay dos filas, dos columnas y 3 valores por posicion
            double[,,] matrix2 = new double[2, 2, 3] { /*Primera fila*/{ { 0.1, 0.2, 0.3 }, { 0.4, 0.5, 0.6 } }, /*Segunda fila*/{ { 0.7, 0.8, 0.9 }, { 1.0, 1.1, 1.2 } } };

            Console.WriteLine("Resultado {0}", matrix2[1, 1, 1]); //Devuelve el valor 1.1


            /*------------------------------------------------------------------------------------------------------------------*/
            /*------------------------------------------------FOR Y FOREACH-----------------------------------------------------*/
            /*------------------------------------------------------------------------------------------------------------------*/

            int[] a = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Resultado, {0}", i);

            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Resultado, {0}", i);

            }

            foreach (var item in a)
            {
                Console.WriteLine("{0 }", item);
            }

            /*------------------------------------------------------------------------------------------------------------------*/
            /*------------------------------------------------SWITCH------------------------------------------------------------*/
            /*------------------------------------------------------------------------------------------------------------------*/

            int sw = 2;

            switch (sw)
            {
                case 1:
                    Console.WriteLine("Esta no saldra nunca");
                    break;
                case 2:
                    Console.WriteLine("Esta saldra siempre");
                    break;
                default:
                    Console.WriteLine("Para cubrir las espaldas");
                    break;
            }


            /*
            //Lo mismo
            var da = 2;
            var rs = da switch
            {
                1 => "Esta no saldra nunca",
                2 => "Esta saldra siempre",
                3 => "Para cubrir las espaldas"
            };
            */


            Console.ReadLine();
        }
    }
}

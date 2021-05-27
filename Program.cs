using System;

namespace T03_5
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
        int A = 1;
        int B = 2;
        int C = 3;
        int D = 4;

        //Mostrar los valores iniciales
        Console.WriteLine("Valor inicial de A es {0}", A);
        Console.WriteLine("Valor inicial de B es {0}", B);
        Console.WriteLine("Valor inicial de C es {0}", C);
        Console.WriteLine("Valor inicial de D es {0}", D);

            //Mostrar los valores sustituidos
            B = C;
            Console.WriteLine("Valor nuevo de B es {0}", B);
            C = A;
            Console.WriteLine("Valor nuevo de C es {0}", C);
            A = D;
            Console.WriteLine("Valor nuevo de A es {0}", A);
            D = B;
            Console.WriteLine("Valor nuevo de D es {0}", D);

        }
    }
}

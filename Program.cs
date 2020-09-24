using System;

namespace BucleDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int miNumero = 101;

            int intentos = 0;

            Console.WriteLine("Introduce un n° entre 0 y 100");

            do{

                intentos++;

                miNumero = int.Parse(Console.ReadLine());

                if (miNumero > aleatorio) Console.WriteLine("El n° es mas bajo");

                if (miNumero < aleatorio) Console.WriteLine("El n° es mas alto");

            } while (aleatorio != miNumero);

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

        }
    }
}

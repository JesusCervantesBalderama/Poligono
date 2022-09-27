using System;

namespace Poligono
{
    class Program
    {
        static void Main(string[] args)
        {
            int lados;
            float medidaporlado, perimetro;

            Console.WriteLine("Escribe el numero de lados del poligono");
            lados = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Apunta la medida de los lados");
            medidaporlado = Single.Parse(Console.ReadLine());
            perimetro = lados + medidaporlado;

            Console.WriteLine("El perimeto del poligono es {0}", perimetro);
        }
    }
}
using System;
using AreaCalculator.Src;

namespace AreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do quadrado: ");
            double alturaQuadrado = Convert.ToDouble(Console.ReadLine());
            Quadrado quadrado = new Quadrado("Quadrado", alturaQuadrado, alturaQuadrado);
            Console.WriteLine($"A área total de um quadrado com altura e base {quadrado.Altura} é de {quadrado.AreaTotal()}");
            Console.ReadKey();

            Console.WriteLine("Digite a altura do triângulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a base do triângulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Triangulo triangulo = new Triangulo("Triângulo", alturaTriangulo, baseTriangulo);
            Console.WriteLine($"A área total de um triângulo com altura {triangulo.Altura} e base {triangulo.Base} é de {triangulo.AreaTotal()}");
            Console.ReadKey();

            Console.WriteLine("Digite a altura do retângulo: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a base do retângulo: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());
            Retangulo retangulo = new Retangulo("Retângulo", alturaRetangulo, baseRetangulo);
            Console.WriteLine($"A área total de um retângulo com altura {retangulo.Altura} e base {retangulo.Base} é de {retangulo.AreaTotal()}");
            Console.ReadKey();
        }
    }
}

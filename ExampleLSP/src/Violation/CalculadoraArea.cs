using System;

namespace ExampleLSP.src.Violation
{
    public static class CalculadoraArea
    {
        public static void ObterArea(Retangulo retangulo)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Area do Retangulo: " + (retangulo.Altura * retangulo.Largura));
            Console.WriteLine("----------------------------");
        }

        public static void Calcular()
        {
            var quadrado = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterArea(quadrado);
        }
    }
}
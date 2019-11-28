using System;

namespace ExampleLSP.src.Correct
{
    public static class CalculadoraArea
    {
        public static void ObterArea(Paralelogramo paralelogramo)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Area do Retangulo: " + (paralelogramo.Altura * paralelogramo.Largura));
            Console.WriteLine("----------------------------");  
        }

        public static void Calcular()
        {
            var quadrado = new Retangulo(10,5);

            ObterArea(quadrado);
        }
    }
}
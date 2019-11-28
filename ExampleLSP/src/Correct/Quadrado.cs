using System;

namespace ExampleLSP.src.Correct
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado() { }

        public Quadrado(double altura, double largura)
            : base(altura, largura)
        {
            if(altura != largura)
                throw new Exception("altura e largura deverao ser iguais!");
        }
    }
}
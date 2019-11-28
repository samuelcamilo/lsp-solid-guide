namespace ExampleLSP.src.Correct
{
    public class Retangulo : Paralelogramo
    {
        public Retangulo() { }

        public Retangulo(double altura, double largura)
            : base(altura, largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
    }
}
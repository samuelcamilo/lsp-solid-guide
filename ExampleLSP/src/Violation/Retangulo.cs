namespace ExampleLSP.src.Violation
{
    public class Retangulo
    {
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }

        public Retangulo() { }

        public Retangulo(double altura, double largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
    }
}
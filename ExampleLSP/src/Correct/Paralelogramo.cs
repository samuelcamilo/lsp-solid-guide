namespace ExampleLSP.src.Correct
{
    public class Paralelogramo
    {
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }

        public Paralelogramo() { }
        public Paralelogramo(double altura, double largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
    }
}
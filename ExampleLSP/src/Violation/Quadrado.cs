namespace ExampleLSP.src.Violation
{
    public class Quadrado : Retangulo
    {
        public override double Altura
        {
            set { base.Altura = base.Largura = value; }
        }

        public override double Largura
        {
            set { base.Largura = base.Altura = value; }
        }

        public Quadrado() : base() { }

        public Quadrado(double altura, double largura) 
            : base(altura, largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
    }
}
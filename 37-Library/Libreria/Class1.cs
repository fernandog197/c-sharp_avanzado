namespace Aritmetica
{
    public class MisMates
    {
        private double a;
        private double b;
        private double r;

        public MisMates (double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double R { get => this.r; }

        public double Suma ()
        {
            r = a + b;
            return r;
        }

        public double Resta ()
        {
            r = a - b;
            return r;
        }

        public double Multiplicacion ()
        {
            r = a * b;
            return r;
        }

        public double Division ()
        {
            r = a / b;
            return r;
        }
    }
}

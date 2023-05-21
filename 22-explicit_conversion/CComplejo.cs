namespace ExplicitConversion
{
    class CComplejo
    {
        //Complejo => a + bi;
        private int a;
        private int b;

        public int A { get => this.a; set => this.a = value; }
        public int B { get => this.b; set => this.b = value; }

        public CComplejo (int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return string.Format("C => {0} + {1}i", this.a, this.b);
        }

        //Creamos una conversion explicita a Reales
        public static explicit operator CReal (CComplejo c)
        {
            CReal aux = new CReal();
            aux.R = c.A;
            return aux;
        }
    }
}
namespace ImplicitConversion
{
    class CReal
    {
        private double r;

        public double R { get => this.r; set => this.r = value; }

        public CReal ()
        {

        }

        public CReal (double r)
        {
            this.r = r;
        }

        public override string ToString()
        {
            return string.Format("R = {0}", this.r);
        }

        //Creamos una conversion implicita de Real a Imaginario
        public static implicit operator CComplejo (CReal r)
        {
            CComplejo aux = new CComplejo((int)r.R, 0);

            return aux;
        }
    }
}
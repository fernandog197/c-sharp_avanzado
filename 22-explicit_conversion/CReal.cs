namespace ExplicitConversion
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
    }
}
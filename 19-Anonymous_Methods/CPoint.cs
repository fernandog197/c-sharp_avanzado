namespace AnonymousMethods
{
    class CPoint
    {
        public delegate void DelMensaje ();
        public DelMensaje mensaje;

        private int x;
        private int y;

        public CPoint (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("x = {0} | y = {1}", this.x, this.y);
        }
    }
}
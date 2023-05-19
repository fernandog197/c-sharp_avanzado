namespace CollectionsGenericObservableCollection
{
    class CPoint : IComparable<CPoint>
    {
        private int x;
        private int y;

        public CPoint (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => this.x; set => this.x = value; }
        public int Y { get => this.y; set => this.y = value; }

        public override string ToString()
        {
            return string.Format("x={0}, y={1}", this.x, this.y);
        }

        public int CompareTo (CPoint p)
        {
            double magA = Math.Sqrt(this.x * this.x + this.y * this.y);
            double magB = Math.Sqrt(p.X * p.X + p.Y * p.Y);

            if(magA > magB)
            {
                return 1;
            }
            
            if(magA < magB)
            {
                return -1;
            }

            return 0;
        }
    }
}
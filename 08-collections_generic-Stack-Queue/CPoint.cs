namespace CollectionsGenericsStacksQueue
{
    class CPoint
    {
        private int x;
        private int y;

        public CPoint (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => this.X; set => this.X = value; }
        public int Y { get => this.Y; set => this.Y = value; }

        public override string ToString()
        {
            return string.Format("x={0}, y={1}", this.x, this.y);
        }
    }
}
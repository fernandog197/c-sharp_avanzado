namespace GenericCollectionsArrayList
{
    class CPunto
    {
        private int x;
        private int y;

        public CPunto (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("x={0}, y={1}", this.x, this.y);
        }
    }
}
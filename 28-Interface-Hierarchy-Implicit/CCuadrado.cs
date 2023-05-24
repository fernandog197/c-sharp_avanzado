namespace InterfacesHierarchyImplicit
{
    class CCuadrado : IArea, IPerimetro
    {
        private int lado;

        public CCuadrado (int lado)
        {
            this.lado = lado;
        }

        //Implementacion explicita de las interfaces!
        void IArea.Calcular ()
        {
            Console.WriteLine("Area = {0}", this.lado * this.lado);
        }

        void IPerimetro.Calcular()
        {
            Console.WriteLine("Perimetro = {0}", this.lado * 4);
        }
    }
}
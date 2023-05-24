namespace InterfacesHierarchyImplicit
{
    class CSuma : ICalcular
    {
        private int a;
        private int b;
        private int r;

        //Implementacion de Calcular
        public int Calculo (int a, int b)
        {
            this.a = a;
            this.b = b;
            this.r = this.a + this.b;

            return this.r;
        }

        //Implementacion de MostrarDatos por jerarquia
        public void MostrarDatos ()
        {
            Console.WriteLine("{0} + {1} = {2}", this.a, this.b, this.r);
        }
    }
}
namespace FinalizableDisposable
{
    //V1
    class CPrueba : IDisposable
    {
        private int a;

        public CPrueba (int a)
        {
            this.a = a;
        }

        public override string ToString()
        {
            return string.Format("El valor es {0}", this.a);
        }

        ~CPrueba ()
        {
            Console.WriteLine("Estamos en el destructor D: Aqui eliminamos lo no administrado {0}", this.a);
        }

        public void Dispose ()
        {
            Console.WriteLine("Estamos en Dispose, aqui liberamos lo no administrado {0}", this.a);

            //Si se uso Dispose, no es necesario el destructor
            GC.SuppressFinalize(this);
        }
    }
}
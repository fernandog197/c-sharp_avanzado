namespace DisposableObjects
{
    //Implementamos IDisposable
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

        public void Dispose ()
        {
            Console.WriteLine("Estamos en Dispose(). Aqui liberamos lo no administrado: {0}", this.a);
        }
    }
}
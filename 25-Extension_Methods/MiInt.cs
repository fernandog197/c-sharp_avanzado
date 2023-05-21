namespace ExtensionMethods
{
    class CMiInt : ISaludador
    {
        private int a;

        public CMiInt (int a)
        {
            this.a = a;
        }

        public override string ToString()
        {
            return string.Format("Su entero es: {0}", this.a);
        }

        public void Saludar ()
        {
            Console.WriteLine("Hola desde la clase CMiInt! {0}", this.a);
        }
    }
}
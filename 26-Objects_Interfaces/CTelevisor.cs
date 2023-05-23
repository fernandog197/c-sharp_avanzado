namespace ObjectsInterfaces
{
    class CTelevisor : IElectronico
    {
        string marca;

        public CTelevisor (string marca)
        {
            this.marca = marca;
        }

        public override string ToString()
        {
            return string.Format("{0} es la marca de su televisor", this.marca);
        }

        public void Encender (bool interruptor)
        {
            if(interruptor)
            {
                Console.WriteLine("Televisor encendido!");
            }
            else
            {
                Console.WriteLine("Televisor apagado");
            }
        }
    }
}
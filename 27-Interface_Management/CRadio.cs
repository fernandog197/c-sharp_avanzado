namespace InterfaceManagement
{
    class CRadio : IElectronico
    {
        string marca;

        public CRadio (string marca)
        {
            this.marca = marca;
        }

        public override string ToString()
        {
            return string.Format("{0} es la marca de su Radio", this.marca);
        }

        public void Encender (bool interruptor)
        {
            if(interruptor)
            {
                Console.WriteLine("Radio encendido!");
            }
            else
            {
                Console.WriteLine("Radio apagado");
            }
        }
    }
}
namespace ObjectsInterfaces
{
    class CPelota
    {
        string tamano;

        public CPelota (string tamano)
        {
            this.tamano = tamano;
        }

        public override string ToString()
        {
            return string.Format("El tamaño de la pelota es {0}", this.tamano);
        }
    }
}
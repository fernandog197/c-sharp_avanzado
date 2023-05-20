namespace GenericClass
{
    //T representa el tipo con el que se trabaja
    class CPoint<T>
    {
        //Creamos atributos del tipo T
        private T x;
        private T y;

        //Definimos el constructor para que tambien reciba variables del tipo T
        public CPoint(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("x = {0} | y = {1}", this.x, this.y);
        }

        public void Reset ()
        {
            //Colocamos el valor de default para el tipo T
            // si es numerico => 0;
            // si es referenciable => null;

            this.x = default(T);
            this.y = default(T);
        }

        public void TypeFounder ()
        {
            if(typeof(T) == typeof(int))
            {
                Console.WriteLine("Trabajo con enteros");
            }
            else
            {
                Console.WriteLine("Trabajo con un tipo diferente: {0}", typeof(T));
            }
        }
    } 
}
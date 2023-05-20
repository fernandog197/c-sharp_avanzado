namespace GenericDelegate
{
    class Program
    {
        //Creamos el delegado generico
        public delegate void myDelegate<T> (T p);

        public static void Main ()
        {
            //Registramos y usamos el StringHandler
            myDelegate<string> stringDelegate = new myDelegate<string>(StringHandler);
            stringDelegate("Esto es un string");

            //Registramos y usamos el DoubleHandler
            myDelegate<double> doubleDelegate = new myDelegate<double>(DoubleHandler);
            doubleDelegate(58.7);
        }

        static void StringHandler (string p)
        {
            Console.WriteLine("Uso string como tipo y mi valor es: {0}", p);
        }

        static void DoubleHandler (double p)
        {
            Console.WriteLine("Uso double como tipo y mi valor es: {0}", p);
        }
    }
}
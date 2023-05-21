namespace ExtensionMethods
{
    class Program
    {
        public static void Main ()
        {
            //Extension de int
            int numero = 55;
            bool esPar = numero.IsEven();

            Console.WriteLine("El numero {0} es par?: {1}", numero, esPar);

            //Extension de double
            double numero02 = 55.18;

            Console.WriteLine(numero02.numberX2());

            //Extension ISaludador
            CMiInt miEntero = new CMiInt(9);
            miEntero.Sonido();
        }
    }
}
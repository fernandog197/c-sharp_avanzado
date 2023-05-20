namespace GenericMethods
{
    class Program
    {
        public static void Main ()
        {
            int x = 5;
            int y = 3;

            Console.WriteLine("x = {0} | y = {1}", x, y);
            Swap<int>(ref x, ref y);
            Console.WriteLine("x = {0} | y = {1}", x, y);

            Console.WriteLine("- - - - - - - - - -");

            double m = 78.9;
            double n = 98.6;

            Console.WriteLine("m = {0} | n = {1}", m, n);
            Swap<double>(ref m, ref n);
            Console.WriteLine("m = {0} | n = {1}", m, n);

            Console.WriteLine("- - - - - - - - - -");

            string o = "Hola";
            string p = "Bebe";

            Console.WriteLine("o = {0} | p = {1}", o, p);
            Swap<string>(ref o, ref p);
            Console.WriteLine("o = {0} | p = {1}", o, p);

            Console.WriteLine("- - - - - - - - - -");
        }

        static void Swap<T> (ref T a, ref T b)
        {
            T aux;
            aux = a;
            a = b;
            b = aux;
        }
    }
}
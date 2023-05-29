using Aritmetica;

namespace TestProyect
{
    class Program
    {
        public static void Main ()
        {
            MisMates mates = new MisMates(5.56, 32.5);

            double resultado = mates.Suma();
            Console.WriteLine("El resultado de la suma es {0}", resultado);

            mates.Multiplicacion();
            Console.WriteLine("El resultado de la multiplicacion es {0}", mates.R);
        }
    }
}
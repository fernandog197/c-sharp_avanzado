namespace ImplicitConversion
{
    class Program
    {
        public static void Main ()
        {
            //Conversion implicita
            CReal real01 = new CReal(3.5);

            CComplejo complejo01 = real01;

            Console.WriteLine(complejo01);
        }
    }
}
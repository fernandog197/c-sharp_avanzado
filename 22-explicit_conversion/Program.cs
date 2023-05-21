namespace ExplicitConversion
{
    class Program
    {
        public static void Main ()
        {
            //Conversion de tipo
            CComplejo complejo01 = new CComplejo(2, 3);

            //NO se puede!
            //CReal real01 = complejo01;

            //La siguiente linea solo sera posible cuando hayamos definido el explicit dentro de la clase CComplejo.    
            CReal real01 = (CReal) complejo01;
            
            //Lo mostramos
            Console.WriteLine(real01);
        }
    }
}
namespace Exceptions03
{
    class Program
    {
        public static void Main ()
        {
            CCaldera miCaldera = new CCaldera("Matic-O-A", 20);
            Random random = new Random();

            while(miCaldera.Funciona)
            {
                try
                {
                    miCaldera.Trabajar(random.Next(10));
                }
                catch(CalderaException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Momento);
                    Console.WriteLine(e.Causa);
                }
            }
        }
    }
}
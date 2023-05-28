namespace FinalizableDisposable
{
    class Program
    {
        public static void Main ()
        {
            //Creamos objetos
            CPrueba objeto01 = new CPrueba(5);
            CPrueba objeto02 = new CPrueba(7);

            Console.WriteLine(objeto01);
            Console.WriteLine(objeto02);

            //Hacemos Dispose del objeto01
            objeto01.Dispose();

            Console.WriteLine("- - - - - Fin del programa - - - - -");
        }
    }
}
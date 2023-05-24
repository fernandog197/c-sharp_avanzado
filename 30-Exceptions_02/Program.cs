namespace Exceptions02
{
    class Program
    {
        public static void Main ()
        {
            /*
                EXCEPCIONES DE APLICACIONES
                Se necesitan de cuatro entidades:
                1) Una clase que representa los detalles de la Excepcion
                2) Un miembro que lanza una instancia de la Excepcion
                3) Un bloque de codigo que invoca el codigo que puede generar la Excepcion
                4) Un bloque que va a catchear o procesar la Excepcion en caso de que ocurra
            */

            CCaldera miCaldera = new CCaldera("Matic-O-A", 20);
            Random random = new Random();

            while(miCaldera.Funciona)
            {
                try
                {
                    miCaldera.Trabajar(random.Next(10));
                }
                // catch (Exception e)
                // {
                //     Console.WriteLine("El mensaje de Excepcion es: {0}", e.Message);
                // }

                //Codigo para catchear nuestra excepcion
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
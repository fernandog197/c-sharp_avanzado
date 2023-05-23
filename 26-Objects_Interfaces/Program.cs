namespace ObjectsInterfaces
{
    class Program
    {
        public static void Main ()
        {
            //Como reconocer si un objeto implementa determinada interfaz

            CTelevisor miTV = new CTelevisor("Sharpy");
            CPelota miPelota = new CPelota("Grande");
            IElectronico object01 = null;

            //METODO 01: por excepcion
            // try
            // {
            //     Console.WriteLine("Probamos la tele");
            //     object01 = (IElectronico)miTV;
            //     object01.Encender(true);
            // }
            // catch (InvalidCastException e)
            // {
                
            //     Console.WriteLine(e.Message);
            // }

            // try
            // {
            //     Console.WriteLine("Probamos la pelota");
            //     object01 = (IElectronico)miPelota;
            //     object01.Encender(true);
            // }
            // catch (InvalidCastException e)
            // {
                
            //     Console.WriteLine(e.Message);
            // }

            // Console.WriteLine("- - - - - -");

            //METODO 02: AS
            // Console.WriteLine("Probamos la tele");
            // object01 = miTV as IElectronico;

            // if(object01 != null)
            // {
            //     object01.Encender(true);
            // }
            // else
            // {
            //     Console.WriteLine("No implementa IElectronico");
            // }

            // Console.WriteLine("Probamos la pelota");
            // object01 = miPelota as IElectronico;

            // if(object01 != null)
            // {
            //     object01.Encender(true);
            // }
            // else
            // {
            //     Console.WriteLine("No implementa IElectronico");
            // }

            //METODO 03: IS
            Console.WriteLine("Probamos tele");

            if(miTV is IElectronico)
            {
                miTV.Encender(true);
            }
            else
            {
                Console.WriteLine("No implementa IElectronico");
            }

            Console.WriteLine("Probamos pelota");

            if(miPelota is IElectronico)
            {
                Console.WriteLine("Wow! Tienes una pelota electronica! D:");
            }
            else
            {
                Console.WriteLine("No implementa IElectronico");
            }
        }
    }
}
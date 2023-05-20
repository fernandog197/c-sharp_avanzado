namespace Nulleable
{
    class Program
    {
        public static void Main ()
        {
            //TIPOS NULLEABLES
            //Los tipos de valor NO pueden aceptar null

            //int valor = null => INCORRECTO!

            /*
            _ Los tipos nulleables pueden representar los mismo valores mas el valor null
            _ Son utiles en bases de datos, pues podemos encontrar columnas no definidas
            _ Para definirlos utilizamos ?
            _ Lo que hacemos realmente es crear una instancia de System.Nulleable<T>
            */

            int? dato = 5;
            Console.WriteLine("dato {0}", dato);

            dato = null;
            Console.WriteLine("dato {0}", dato);

            double? precio = null;
            
            precio = 6.7;
            Console.WriteLine("precio {0}", precio);

            //String NO es nulleable
            //string? nombre = "Kevin"; => marca un error, ya que string ya es un tipo por referencia
            string nombre = null; //=> esta seria la forma correcta

            //Podemos verificar si una variable es null
            //precio = null;

            if(precio.HasValue)
            {
                Console.WriteLine("Tiene valor {0}", precio.Value);
            }
            else
            {
                Console.WriteLine("No tiene valor");
            }

            //El operador ?? nos permite asignar un valor a la variable, en caso de esta ser null
            double? numeroRandom = Asignador() ?? 5.55;
            Console.WriteLine(numeroRandom);
        }

        public static double? Asignador ()
        {
            //return 4.5;
            return null;
        }
    }
}
namespace Action
{
    class Program
    {
        public static void Main ()
        {
            /*
            Action nos permite crear delegados inmediatamente, para un maximo de 16 parametros, pero, el tipo de 
            retorno debe ser void.
            */

            int n = 5;
            string msj = "Hola a todos";

            //Usamos Action para registrar el handler con el delegado
            Action<string, int> delegadoAction = new Action<string, int>(RepeatMessage);

            //Invocamos el delegado
            delegadoAction(msj, n);
        }

        //Declaramos el handler
        static void RepeatMessage (string mensaje, int veces)
        {
            int n = 0;

            for(n = 0; n < veces; n++)
            {
                Console.WriteLine(mensaje);
            }
        }
    }
}
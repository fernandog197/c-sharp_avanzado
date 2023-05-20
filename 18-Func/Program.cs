namespace Func
{
    class Program
    {
        /*
            Func funciona de manera similar a Action, solo que este nos permite un tipo de retorno distinto
            a void
        */
        public static void Main ()
        {
            int x = 5;
            int y = 9;

            //Definimos el delegado, el ultimo tipo listado es, siempre, el tipo de retorno
            Func<int, int, int> delegateFunc = new Func<int, int, int>(Suma);

            //Invocamos e imprimimos el resultado
            Console.WriteLine(delegateFunc(x, y));
        }

        //Declaramos el handler
        static int Suma (int a, int b)
        {
            int r = 0;
            r = a + b;
            return r;
        }
    }
}
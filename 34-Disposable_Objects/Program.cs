namespace DisposableObjects
{
    class Program
    {
        public static void Main ()
        {
            /*
                |----------| Tipos finalizables |----------|

                _ Si deseamos que los recursos sean liberados tan pronto como sea posible, en lugar de que haga el GC, podemos implementar
                la interfaz IDisposable.
                
                _ Al invocar el metodo Dispose(), se liberan los recursos no administrados pero el objeto sigue existiendo.
            */

            CPrueba objeto = new CPrueba(5);
            Console.WriteLine(objeto);

            //Primera forma
            // objeto.Dispose();

            //Segunda forma
            // if(objeto is IDisposable)
            // {
            //     objeto.Dispose();
            // }

            //Tercera forma
            // try
            // {
            //     Console.Write(objeto);
            // }
            // finally
            // {
            //     objeto.Dispose();
            // }

            //Cuarta forma
            //Con esta tecnica Dispose es invocado automaticamente. Se pueden listar varios objetos en el using
            using (CPrueba objeto02 = new CPrueba(7))
            {
                Console.WriteLine(objeto02);
            }
        }
    }
}
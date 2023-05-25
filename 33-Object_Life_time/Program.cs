namespace ObjectLifetime
{
    class Program
    {
        public static void Main ()
        {
            //Obtenemos la cantidad de bytes en el Heap
            long bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine("El Heap utiliza {0} bytes", bytesHeap);

            //Obtenemos la cantidad de generaciones, basada en 0 por eso +1
            int maxGeneration = GC.MaxGeneration + 1;
            Console.WriteLine("Se tienen {0} generaciones", maxGeneration);

            //Creamos una instancia
            CPrueba miPrueba = new CPrueba(5);

            //Actualizamos la cantidad de bytes en el Heap
            bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine("El Heap utiliza {0} bytes", bytesHeap);

            //Obtenemos la generacion de una instancia
            int generacionInstancia = GC.GetGeneration(miPrueba);
            Console.WriteLine("La generacion de la instancia es: {0}", generacionInstancia);

            /*
                FORZAR GC
                _ Solo hacerlo en situaciones especiales.
                _ Cuando la aplicacion entra en un bloque que no debe ser interrumpido por el GC.
                _ La aplicacion creo una gran variedad de instancias y se necesita liberar la mayor cantidad de memoria posible.

                GC.Colletc();
                GC.WaitForPendingFinalizers(); -> Estos metodos van de la mano. Uno inicia la recoleccion y el otro espera a que las
                clases involucradas finalizen correctamente con la destruccion de objetos D:

                Para recolectar de una generacion en particular
                GC.Collect(0);
                GC.WaitForPendingFinalizers();
            
            */
        }
    }
}
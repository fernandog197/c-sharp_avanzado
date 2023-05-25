namespace ObjectLifetime
{
    class CPrueba
    {
        private int a;

        public CPrueba (int a)
        {
            this.a = a;
        }

        public override string ToString()
        {
            return string.Format("El valor es {0}", this.a);
        }

        /*
        |----------| Tipos finalizables |----------|

        _ Object tiene un metodo virtual Finale()
        
        _ Cuando se hace el override de Finalize tenemos un lugar donde llevar a cabo la limpieza de la clase
        
        _ No se puede invocar directamente, porque es un metodo protegido
        
        _ Lo invoca el GC antes de eliminar el objeto de la memoria
        
        _ No se puede hacer override de tipos estructura
        
        _ En la practica, casi nunca haremos esto, salvo que tengamos recursos no administrados que necesiten ser eliminados manualmente:
        PInvoke, COM, memoria no administrada, etc.
        */

        //No hacemos uso de override.Utilizamos el destructor para esto
        ~CPrueba ()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Aqui liberamos recursos no administrados");
            Console.Beep(600, 50);
        }
    }
}
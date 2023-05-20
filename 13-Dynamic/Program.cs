namespace Dynamic
{
    class Program
    {
        public static void Main ()
        {
            /*
            _ Dynamic se puede ver como una forma de System.Object
            _ Cualquier valor puede ser asignado a Dynamic
            _ NO es fuertemente tipificado, o sea, puede cambiar el tipo asignado inicialmente
            */

            dynamic a = 5;
            Console.WriteLine("Tipo: {0}, Valor: {1}", a.GetType(), a);

            a = "Hola a todos";
            Console.WriteLine("Tipo: {0}, Valor: {1}", a.GetType(), a);

            /*
            _ A diferencia de object, en dynamic se conoce el tipo hasta el tiempo de ejecucion
            _ Dynamic se puede usar como tipo de retorno
            _ NO se puede usar en expresiones lambda o en metodos anonimos
            _ Puede resultar util si nos comunicamos con bibliotecas COM
            */
        }
    }
}
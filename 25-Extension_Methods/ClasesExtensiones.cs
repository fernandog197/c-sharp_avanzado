namespace ExtensionMethods
{
    //La clase donde ser guardan las extensiones debe ser static
    static class ClasesExtensiones
    {
        //_ El metodo que extiende debe ser estatico
        //_ El primer parametro lleva this y representa el tipo que estamos extendiendo
        public static bool IsEven (this int i)
        {
            return i % 2 == 0;
        }

        //Este extiende a un doble
        public static double numberX2 (this double d)
        {
            return d * 2;
        }

        //Este siguiente metodo solo se extiende a las clases que implementen la interfaz ISaludador
        public static void Sonido (this ISaludador s)
        {
            Console.Beep();
        }
    }
}
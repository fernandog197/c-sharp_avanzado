namespace Attributes
{
    //[Obsolete]
    [Obsolete("Usa la nueva version CPrueba02")]

    class CPrueba
    {
        public CPrueba ()
        {
            Console.WriteLine("Version 01");
        }
    }

    [Datos("Clase por Nicosio")]
    class CPrueba02
    {
        public CPrueba02 ()
        {
            Console.WriteLine("Version 02");
        }
    }
}
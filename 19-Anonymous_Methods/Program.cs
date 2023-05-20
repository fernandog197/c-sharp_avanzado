namespace AnonymousMethods
{
    class Program
    {
        public static void Main ()
        {
            CPoint myPoint = new CPoint(5, 6);

            myPoint.mensaje += delegate ()
            {
                Console.WriteLine("Desde el metodo anonimo");
            };

            //Invocamos
            myPoint.mensaje();

            //Asignamos otro handler
            myPoint.mensaje += delegate ()
            {
                Console.WriteLine("Este es otro metodo anonimo");
            };

            myPoint.mensaje();
        }
    }
}
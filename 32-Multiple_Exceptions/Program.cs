namespace MultipleExceptions
{
    class Program
    {
        public static void Main ()
        {
            CCaldera miCaldera = new CCaldera("O-Matic", 20);

            try
            {
                //Forzamos una Excepcion de argumento fuera de rango
                miCaldera.Trabajar(-10);
            }
            catch (CalderaException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            //Dejamos SIEMPRE la excepsion mas general para el final. De esta manera cualquie excepcion que no haya sido capturada
            //previamente, caera en esta ultima.
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //finally contiene codigo que sera ejecuta SIEMPRE, ya sea que haya o no Excepcion e independiente de su tipo
            finally
            {
                Console.WriteLine("Este codigo se ejecuta siempre! D:");
            }
        }
    }
}
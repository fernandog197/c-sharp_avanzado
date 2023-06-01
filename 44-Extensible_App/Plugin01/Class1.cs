using LibraryTiposPlugin;

namespace PluginSuma
{
    //Antes que nada, hacemos referencia a TiposPlugin

    //Colocamos el atributo definido en TiposPlugin
    [CInfoPlugIn(Creator = "Miguel", Information = "Return double, Requiere 2 operandos a sumar")]
    //Creamos la clase que implementa la interfaz, tambien definida en TiposPlugin
    public class Suma : IPlugInMates
    {
        public double Calcular (double a, double b)
        {
            double r = a + b;
            return r;
        }
    }
}
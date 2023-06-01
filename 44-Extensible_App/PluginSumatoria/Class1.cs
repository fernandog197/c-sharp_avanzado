using LibraryTiposPlugin;

namespace PluginSumatoria
{
    //No olvidar añadir referencia a TiposPlugin

    //Colocamos el atributo definido en TiposPlugin
    [CInfoPlugIn(Creator = "Miguel", Information = "Return double, 1er operando valor, 2do operando 0(cero)")]

    //Creamos la clase que implementa la interfaz
    public class Sumatoria : IPlugInMates
    {
        public double Calcular (double a, double b)
        {
            int n = 0;
            double sumatoria = 0;

            for (n = 0; n < a; n++)
            {
                sumatoria += n;
            }

            return sumatoria;
        }
    }
}


using AritmeticaAttribute;

namespace AttributeLibraryPrueba
{
    class Program
    {
        public static void Main ()
        {
            //Usaremos Reflection con early binding

            //Obtenemos el tipo de la clase
            Type t = typeof(Operaciones);

            //Obtenemos la lista de atributos
            object[] atributos = t.GetCustomAttributes(false);

            //Mostramos los atributos
            foreach(DatosAttribute atributo in atributos)
            {
                Console.WriteLine("{0}", atributo.Dato);
            }
        }
    }
}
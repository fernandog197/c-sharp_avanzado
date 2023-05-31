using System;

using System.Reflection;

namespace AttributeLateBinding
{
    class Program
    {
        public static void Main ()
        {
            //Usaremos Reflection con Late Binding
            //Primero debemos copiar el dll en la carpeta correspondiente
            try
            {
                //Cargamos el Assembly
                string assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Aritmetica.dll");
                Assembly asm = Assembly.LoadFrom(assemblyPath);

                //Obtenemos el tipo del Atributo
                Type datoAt = asm.GetType("AritmeticaAttribute.DatosAttribute");

                //Obtenemos el tipo de la propiedad
                PropertyInfo datoProp = datoAt.GetProperty("Dato");

                //Obtenemos la lista de tipo del Assembly
                Type[] tipos = asm.GetTypes();

                //Para cada tipo en el Assembly obtenemos el atributo
                foreach(Type t in tipos)
                {
                    object[] objectos = t.GetCustomAttributes(datoAt, false);

                    //Recorremos todos los atributos
                    foreach(object obj in objectos)
                    {
                        Console.WriteLine("{0}, {1}", t.Name, datoProp.GetValue(obj, null));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
using System;

using System.Reflection;
using System.IO;

namespace ReflectionAssemblyLoad
{
    class Program
    {
        public static void Main ()
        {
            //Cargamos un assembly y vemos sus tipos
            Assembly asm = null;

            try
            {
                //Obtenemos la ruta del Assembly
                string assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Libreria.dll");

                //Cargamos el Assembly
                asm = Assembly.LoadFrom(assemblyPath);
                
                EncuentraTipos(asm);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            if(asm != null)
            {
                //Obtenemos el tipo
                Type mates = asm.GetType("Aritmetica.MisMates");

                try
                {
                    //Creamos la instancia
                    object obj = Activator.CreateInstance(mates, new object[] { 5, 3 });
                    Console.WriteLine("Tenemos instancia de {0}", obj);

                    //Obtenemos el metodo
                    MethodInfo suma = mates.GetMethod("Suma");

                    //Obtenemos la propiedad R
                    PropertyInfo resultado = mates.GetProperty("R");

                    double r = 0;

                    //Invocamos el metodo
                    suma.Invoke(obj, null);

                    //Ejemplo de invocacion si el metodo requiere parametros
                    //suma.Invoke(obj, new object[] { 5, 3 });

                    //Invocamos la propiedad
                    r = (double)resultado.GetValue(obj);
                    Console.WriteLine("El resultado es {0}", r);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        public static void EncuentraTipos (Assembly asm)
        {
            //Mostramos el nombre del Assembly
            Console.WriteLine("Los tipos encontrados en {0} son: ", asm.FullName);

            //Obtenemos los tipos
            Type[] tipos = asm.GetTypes();

            //Los desplegamos
            foreach(Type t in tipos)
            {
                Console.WriteLine(t);
            }
        }
    }
}
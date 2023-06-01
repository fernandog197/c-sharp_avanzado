using System;

using System.Reflection;

namespace AppDomain02
{
    class Program
    {
        public static void Main ()
        {
            //Cuando un executable inicia, el CLR lo coloca en el AppDomain de default del proceso que lo alberga.
            //Nosotros podemos tener acceso a ese AppDomain de default

            AppDomain AD = AppDomain.CurrentDomain;

            //Imprimimos la informacion que nos proporciona
            Console.WriteLine("Nombre del dominio: {0}", AD.FriendlyName);
            Console.WriteLine("ID del dominio en el proceso: {0}", AD.Id);
            Console.WriteLine("Directorio base del dominio: {0}", AD.BaseDirectory);

            //Verificamos si es el default
            if(AD.IsDefaultAppDomain())
            {
                Console.WriteLine("Es el default");
            }
            else
            {
                Console.WriteLine("No es el default");
            }

            Console.WriteLine("- - - - -");

            //Podemos encontrar los Assemblies que el AppDomain esta utilizando
            Assembly[] ADAssemblies = AD.GetAssemblies();

            //Los recorremos
            foreach(Assembly asm in ADAssemblies)
            {
                Console.WriteLine("AssemblyNombre: {0} || AssemblyVersion: {1}", asm.GetName().Name, asm.GetName().Version);
            }
        }
    }
}
using System;

using System.IO;

namespace AppDomain03
{
    class Program
    {
        public static void Main ()
        {
            AppDomain dAD = AppDomain.CurrentDomain;

            //Colocamos el handler para la carga del Assembly
            dAD.AssemblyLoad += handlerCarga;

            //Colocamos el handler para la descarga del AppDomain
            dAD.ProcessExit += handlerDescarga;

            ListaAssemblies(dAD);

            //Creamos un AppDomain nuevo
            AppDomain nuevoAD = AppDomain.CreateDomain("NuestroAD");

            //Cargamos nuestro Assembly en el nuevo AD
            try
            {
                string assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Aritmetica.dll");
                nuevoAD.Load(assemblyPath);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            ListaAssemblies(nuevoAD);

            AppDomain.Unload(nuevoAD);
        }

        public static void ListaAssemblies (AppDomain aAD)
        {
            var assemblies = from asm in aAD.GetAssemblies()
                                orderby asm.GetName().Name
                                select asm;
            
            Console.WriteLine("Assemblies encontrados en {0}", aAD.FriendlyName);

            foreach(var asm in assemblies)
            {
                Console.WriteLine("Nombre: {0} - Version {1}", asm.GetName().Name, asm.GetName().Version);
            }
        }

        //Handler para detectar la carga de un nuevo Assembly
        public static void handlerCarga (System.Object o, AssemblyLoadEventArgs s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     Se cargo {0}", s.LoadedAssembly.GetName().Name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Handler para detectar cuando se sale del proceso al descargar el AppDomain
        public static void handlerDescarga (System.Object o, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     Se descargo el AppDomain");
        }
    }
}
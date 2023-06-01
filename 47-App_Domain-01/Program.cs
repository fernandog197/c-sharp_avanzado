using System;

using System.Linq;

using System.Diagnostics;

namespace AppDomain01
{
    class Program
    {
        public static void Main ()
        {
            //Hacemos varias operaciones con los procesos de la maquina

            //Obtenemos una lista de los procesos
            var procesos = from proc in Process.GetProcesses()
                            orderby proc.Id select proc;

            //Recorremos los procesos encontrados
            foreach(var proceso in procesos)
            {
                //Imprimimos el Id y el nombre
                Console.WriteLine("PID: {0}, Nombre: {1}", proceso.Id, proceso.ProcessName);
            }

            Console.WriteLine("- - - - -");

            //Podemos iniciar y finalizar procesos
            Process otroProceso = null;

            try
            {
                //Iniciamos el procesos y le pasamos un parametro
                otroProceso = Process.Start("chrome.exe", "www.instagram.com");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Oprime una tecla para continuar");
            Console.ReadKey();

            try
            {
                //Finalizamos el procesos
                otroProceso.Kill();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
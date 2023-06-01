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

            //12224
            //Obtener un procesos via PID
            Process miProceso = null;
            int pid = 12224;
            try
            {
                miProceso = Process.GetProcessById(pid);
                Console.WriteLine("PID: {0}, Nombre: {1}", miProceso.Id, miProceso.ProcessName);

                //Obtenemos la lista de hilos en el proceso
                ProcessThreadCollection hilos = miProceso.Threads;

                //Recorremos los hilos encontrados
                foreach(ProcessThread hilo in hilos)
                {
                    Console.WriteLine("ID Hilo: {0} - Inicio: {1} - Prioridad: {2}", hilo.Id, hilo.StartTime, hilo.PriorityLevel);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("- - - - -");

            //Un modulo es un dll o .exe alojado en un proceso
            //Un sistema de 32 no puede acceder a un modulo de 64
            Console.WriteLine("Los modulos del proceso - - {0} - - son: ", miProceso.ProcessName);

            //Obtenemos los modulos
            ProcessModuleCollection modulos = miProceso.Modules;
            foreach(ProcessModule modulo in modulos)
            {
                Console.WriteLine("Modulo: {0}", modulo.ModuleName);
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
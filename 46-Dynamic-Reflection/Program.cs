using System;

using System.Reflection;

namespace DynamicReflection
{
    class Program
    {
        public static void Main ()
        {
            /*
                _ Existe un runtime complementario llamado DLR (Dynamic Language Runtime) que permite descubrir los tipos en tiempo de tiempo de ejecucion, sin chequeos por parte del compilador.
                
                _ Permite tener codigo muy flexible, asi como tambien trabajar con diferentes plataformas y lenguajes de programacion.
                
                _ Tambien permiter adicionar o remover tipos de la memoria en tiempo de ejecucion.

                Haremos uso de dynamic para simplicar el codigo de Reflextion en el Late Binding.
            */

            try
            {
                //Cargamos el Assembly
                string assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Aritmetica.dll");
                Assembly asm = Assembly.LoadFrom(assemblyPath);

                //Obtnemos el metadato del tipo deseado
                Type operaciones = asm.GetType("AritmeticaAttribute.Operaciones");

                //Creamos el objeto
                dynamic newObjeto = Activator.CreateInstance(operaciones, new object[] {5, 6});//-> Notar simplicacion de la sintaxis

                //Invocamos el metodo
                newObjeto.Suma();

                //Trabajamos con la propiedad
                double resultado = newObjeto.R;
                Console.WriteLine("El resultado es: {0}", resultado);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
            }
        }
    }
}
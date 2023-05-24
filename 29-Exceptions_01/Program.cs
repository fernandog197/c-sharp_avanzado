using System;
using System.Collections;

namespace Exceptions01
{
    class Program
    {
        public static void Main ()
        {
            CCaldera miCaldera = new CCaldera("O-Matic", 20);

            // //V1
            // for(int i = 0; i < 10; i++)
            // {
            //     miCaldera.Trabajar(20);
            // }

            // //V2
            // try
            // {
            //     for(int i = 0; i < 10; i++)
            //     {
            //         miCaldera.Trabajar(20);
            //     }
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("\nSucedio la excepcion!");

            //     Console.WriteLine("En este metodo: {0}", e.TargetSite);
            //     Console.WriteLine("Con este mensaje de error: {0}", e.Message);
            //     Console.WriteLine("Fuente: {0}", e.Source);

            //     Console.WriteLine("Clase donde ocurrio: {0}", e.TargetSite.DeclaringType);
            //     Console.WriteLine("Tipo de miembro: {0}", e.TargetSite.MemberType);

            //     Console.WriteLine("Stack: {0}", e.StackTrace);
            // }

            //V3
            // try
            // {
            //     for(int i = 0; i < 10; i++)
            //     {
            //         miCaldera.Trabajar(20);
            //     }
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("\nSucedio la excepcion!");

            //     Console.WriteLine("En este metodo: {0}", e.TargetSite);
            //     Console.WriteLine("Con este mensaje de error: {0}", e.Message);
            //     Console.WriteLine("Fuente: {0}", e.Source);

            //     Console.WriteLine("Clase donde ocurrio: {0}", e.TargetSite.DeclaringType);
            //     Console.WriteLine("Tipo de miembro: {0}", e.TargetSite.MemberType);

            //     Console.WriteLine("Stack: {0}", e.StackTrace);

            //     Console.WriteLine("Help Link: {0}", e.HelpLink);
            // }

            //V4
            try
            {
                for(int i = 0; i < 10; i++)
                {
                    miCaldera.Trabajar(20);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSucedio la excepcion!");

                Console.WriteLine("En este metodo: {0}", e.TargetSite);
                Console.WriteLine("Con este mensaje de error: {0}", e.Message);
                Console.WriteLine("Fuente: {0}", e.Source);

                Console.WriteLine("Clase donde ocurrio: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Tipo de miembro: {0}", e.TargetSite.MemberType);

                Console.WriteLine("Stack: {0}", e.StackTrace);

                Console.WriteLine("Help Link: {0}", e.HelpLink);

                Console.WriteLine("Mostramos los datos propios");
                //Verificamos su existencia
                if(e.Data != null)
                {
                    //Imprimimos los datos extras
                    foreach(DictionaryEntry dato in e.Data)
                    {
                        Console.WriteLine("-> {0} -> {1}", dato.Key, dato.Value);
                    }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace GenericCollectionsArrayList
{
    class Program
    {
        public static void Main ()
        {
            List<int> genericList = new List<int>();
            int n = 0;
            int r = 0;

            genericList.Add(7);
            genericList.Add(5);
            genericList.Add(4);
            genericList.Add(3);
            genericList.Add(8);
            genericList.Add(9);

            //Recorremos con ciclo for
            for(n=0; n<genericList.Count; n++)
            {
                //NO hay necesidad de type cast
                r = genericList[n];
                Console.WriteLine("[{0}]", r);
            }

            Console.WriteLine("- - - - -");

            //Chequeamos si existe determinado elemento
            Console.WriteLine(genericList.Contains<int>(3));
            Console.WriteLine(genericList.Contains<int>(15));

            Console.WriteLine("- - - - -");

            //Obtenemos el indice de un elemento
            Console.WriteLine(genericList.IndexOf(8));

            Console.WriteLine("- - - - -");

            //Insertamos un elemento en un indice especifico
            genericList.Insert(2, 55);

            foreach (int e in genericList)
            {
                Console.WriteLine("[{0}]", e);
            }

            Console.WriteLine("- - - - -");

            //Eliminamos un elemento de un indice en particular
            genericList.RemoveAt(3);

            foreach (int e in genericList)
            {
                Console.WriteLine("[{0}]", e);
            }

            Console.WriteLine("- - - - -");

            //Podemos eliminar un elemento en particular -> elimina la primera ocurrencia
            genericList.Remove(8);

            foreach (int e in genericList)
            {
                Console.WriteLine("[{0}]", e);
            }

            Console.WriteLine("- - - - -");

            //Invertimos el orden de la lista
            genericList.Reverse();

            foreach (int e in genericList)
            {
                Console.WriteLine("[{0}]", e);
            }

            Console.WriteLine("- - - - -");

            //Ordenamos la lista
            genericList.Sort();

            foreach (int e in genericList)
            {
                Console.WriteLine("[{0}]", e);
            }

            Console.WriteLine("- - - - -");

            //Creamos una lista para nuestra clase CPunto
            List<CPunto> points = new List<CPunto>();

            points.Add(new CPunto(5, 3));
            points.Add(new CPunto(7, 8));
            points.Add(new CPunto(12, 3));
            points.Add(new CPunto(6, 2));

            foreach(CPunto point in points)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("- - - - -");

            //Si no implementamos IComparable no funciona Sort()
            //points.Sort();

            //Convertimos nuestra lista a un arreglo
            CPunto[] arrayPoints = points.ToArray();

            foreach(CPunto point in arrayPoints)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("- - - - -");
        }
    }
}
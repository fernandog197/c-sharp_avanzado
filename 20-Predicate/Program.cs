using System;
using System.Collections.Generic;

namespace Predicate
{
    class Program
    {
        public static void Main ()
        {
            /*
            _ System.Predicate<T> es un delegado generico que representa un metodo que hace 2 cosas:
            1) define un criterio o condicion y
            2) devuelve un booleano en funcion de si, el objeto estudiado, cumple o no con este criterio o condicion.

            _ public List<T> FindAll(Predicate<T> match) recorre los elementos de la lista, los evalua como parametros del Predicate<T> y, en caso de cumplirse la condicion, incluye los elementos en una nueva lista. Este metodo, sino igual, es muy similar al Map de JS.
            */

            List<int> intList = new List<int>();

            intList.AddRange(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});

            //Definimos el delegado
            Predicate<int> delegateIsEven = new Predicate<int>(IsEven);

            //Invocamos el metodo
            List<int> evenNumbers = intList.FindAll(delegateIsEven);

            //Mostramos nuestra primera lista y la que se obtiene de aplicar el FindAll.
            PrintList(intList);
            Console.WriteLine();
            PrintList(evenNumbers);
        }

        static bool IsEven (int value)
        {
            return value % 2 == 0;
        }

        static bool InRange (int value)
        {
            return value > 3 && value < 7;
        }

        public static void PrintList<T> (List<T> myList)
        {
            int n = 0;
            int length = myList.Count;

            for(n=0; n<length; n++)
            {
                Console.Write("[{0}] - ", myList[n]);
            }

            Console.WriteLine();
        }
    }
}
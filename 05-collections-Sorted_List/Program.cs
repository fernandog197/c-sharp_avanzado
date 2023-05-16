using System;
using System.Collections;

namespace CollectionsSortedList
{
    class Program
    {
        public static void Main ()
        {
            /*
            La clase SortedList en el espacio de nombres System.Collections es una colección que almacena pares clave-valor, donde los elementos se ordenan automáticamente por la clave. Es similar a un diccionario, pero mantiene los elementos ordenados en función de la clave en lugar de insertarlos en un orden arbitrario.

            Caracteristicas principales:
            _ Almacena elementos en pares clave-valor.
            _ Los elementos se ordenan automáticamente por la clave.
            _ Permite el acceso a los elementos mediante la clave.
            _ Es una estructura de datos basada en un árbol binario de búsqueda.
            _ Proporciona un rendimiento eficiente para operaciones de búsqueda y acceso a los elementos.

            Metodos principales:
            1) Add: Agrega un par clave-valor a la SortedList.
            2) Remove: Elimina el elemento con la clave especificada de la SortedList.
            3) ContainsKey: Verifica si la SortedList contiene una clave específica.
            4) ContainsValue: Verifica si la SortedList contiene un valor específico.
            5) Clear: Elimina todos los elementos de la SortedList.
            6) GetEnumerator: Devuelve un enumerador que recorre en orden los elementos de la SortedList.
            7) Count: Obtiene el número de elementos almacenados en la SortedList.
            8) IndexOfKey: Obtiene el índice de base cero de la clave especificada en la SortedList.
            9) IndexOfValue: Obtiene el índice de base cero del valor especificado en la SortedList.
            */

            SortedList sortedList = new SortedList();

            //Adicionamos
            sortedList.Add(754, "Honda");
            sortedList.Add(123, "Volvo");
            sortedList.Add(587, "Nissan");
            sortedList.Add(323, "Fiat");

            //Iteramos
            foreach (DictionaryEntry element in sortedList)
            {
                Console.Write("[{0}: {1}]", element.Key, element.Value);
            }
            Console.WriteLine();
            Console.WriteLine("- - - - -");

            //Cantidad de elementos
            Console.WriteLine("Cantidad de elementos: {0}", sortedList.Count);
            Console.WriteLine("- - - - -");

            //Verificar si contiene un elemento
            Console.WriteLine(sortedList.Contains(123));
            Console.WriteLine(sortedList.Contains(23));

            //Verificamos por key y por value
            Console.WriteLine(sortedList.ContainsKey(123));
            Console.WriteLine(sortedList.ContainsValue("Fiat"));

            Console.WriteLine("- - - - -");

            //Obtener elementos por indice
            Console.WriteLine(sortedList.GetKey(2)); //=> devuelve la key del indice ingresado
            Console.WriteLine(sortedList.GetByIndex(2)); //=> devuelve el value del indice ingresado
        }
    }
}
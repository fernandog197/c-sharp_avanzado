using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        public static void Main ()
        {
            /*
            HashTable es una colección en la que los elementos se almacenan y se acceden a través de claves y valores. Utiliza una función de hash para calcular un índice donde se almacenan los elementos, lo que permite un acceso rápido a los mismos.

            Caracteristicas principales:
            _ Almacenamiento basado en claves y valores: Cada elemento en un HashTable está compuesto por una clave única y un valor asociado.
            _ Búsqueda rápida: Utilizando la función de hash, se puede acceder rápidamente a los elementos en función de sus claves, lo que permite una búsqueda eficiente.
            _ No ordenado: Los elementos en un HashTable no se almacenan en un orden específico. No se garantiza el orden de inserción o recuperación.
            _ Tamaño dinámico: Los HashTables tienen un tamaño dinámico y pueden crecer automáticamente a medida que se agregan más elementos.

            Metodos principales:
            1) Add(key, value): Agrega un elemento con la clave y el valor especificados al HashTable.
            2) Remove(key): Elimina el elemento con la clave especificada del HashTable.
            3) ContainsKey(key): Verifica si el HashTable contiene un elemento con la clave especificada.
            4) ContainsValue(value): Verifica si el HashTable contiene un elemento con el valor especificado.
            5) Clear(): Elimina todos los elementos del HashTable.
            6) Count: Obtiene el número de elementos almacenados en el HashTable.
            7) Keys: Obtiene una colección de todas las claves almacenadas en el HashTable.
            8) Values: Obtiene una colección de todos los valores almacenados en el HashTable.
            */

            Hashtable hashTable = new Hashtable();

            //Adicionamos elementos
            hashTable.Add(123, "Hola");
            hashTable.Add(234, "Saludos");
            hashTable.Add(45, "Adios");
            hashTable.Add(567, "C#");
            hashTable.Add(12763, "Programacion");

            foreach(DictionaryEntry element in hashTable)
            {
                Console.Write("[{0}, {1}], ", element.Key, element.Value);
            }

            Console.WriteLine("");
            Console.WriteLine("- - - - -");

            //Intentamos añadir un nuevo elemento con llave repetida
            // hashTable.Add(123, "Nuevo elemento"); => arroja un error

            Console.WriteLine("- - - - -");

            //Cantidad de elementos
            Console.WriteLine(hashTable.Count);
            Console.WriteLine("- - - - -");

            //Obtenemos el elemento de determinada llave
            Console.WriteLine(hashTable[567]);
            Console.WriteLine(hashTable[445]);

            Console.WriteLine("- - - - -");

            //Colocamos elemento en un llave
            hashTable[45] = "Nuevo elemento";
            hashTable[300] = "Analogo a Add()";//Tambien adiciona elementos

            foreach(DictionaryEntry element in hashTable)
            {
                Console.Write("[{0}, {1}], ", element.Key, element.Value);
            }

            Console.WriteLine("");
            Console.WriteLine("- - - - -");

            //Verificamos si existe un elemento en nuestra HashTable
            Console.WriteLine(hashTable.Contains(567));
            Console.WriteLine(hashTable.Contains(335));

            Console.WriteLine("- - - - -");

            //Eliminamos un elemento
            hashTable.Remove(234);

            foreach(DictionaryEntry element in hashTable)
            {
                Console.Write("[{0}, {1}], ", element.Key, element.Value);
            }

            Console.WriteLine("");
            Console.WriteLine("- - - - -");

            foreach(int key in hashTable.Keys)
            {
                Console.Write("[{0}], ", key);
            }

            Console.WriteLine();
            Console.WriteLine("- - - - -");

            foreach(string value in hashTable.Values)
            {
                Console.Write("[{0}], ", value);
            }

            Console.WriteLine();
            Console.WriteLine("- - - - -");

            
        }
    }
}
using System;
using System.Collections;

namespace CollectionsArrayList01
{
    class Program
    {
        public static void Main ()
        {
            /*
            Un ArrayList en C# es una estructura de datos que se utiliza para almacenar y manipular colecciones de objetos de manera dinámica. A diferencia de los arreglos estáticos, el tamaño de un ArrayList puede crecer o disminuir dinámicamente a medida que se agregan o eliminan elementos.

            Las principales características de un ArrayList son las siguientes:

            _ Almacenamiento dinámico: Un ArrayList puede crecer o disminuir su tamaño automáticamente según se agreguen o eliminen elementos. No es necesario especificar un tamaño fijo al crearlo.

            _ Admite elementos de cualquier tipo: Un ArrayList puede contener elementos de cualquier tipo, ya sean tipos de datos primitivos (como int, string, etc.) o tipos de referencia (clases personalizadas).

            _ Acceso por índice: Los elementos en un ArrayList se almacenan en un orden secuencial y se pueden acceder mediante índices. Puedes obtener, modificar o eliminar elementos según su posición en el ArrayList.

            _ Métodos de manipulación: Los ArrayList proporcionan métodos para agregar elementos al final de la lista, insertar elementos en una posición específica, eliminar elementos, buscar elementos, ordenar la lista, etc.

            _ Capacidad flexible: A medida que se agregan elementos a un ArrayList, su capacidad se ajusta automáticamente para adaptarse al tamaño actual de la lista. Esto permite un uso eficiente de la memoria.

            Es importante tener en cuenta que, a partir de C# 2.0, se recomienda el uso de la colección genérica List<T> en lugar de ArrayList, ya que proporciona un mejor rendimiento y evita la necesidad de realizar conversiones de tipo. Sin embargo, el uso de ArrayList todavía es válido en ciertos escenarios donde se requiere la flexibilidad de almacenar elementos de diferentes tipos en una colección.

            Algunos de sus principales metodos son:

            1) Add: Agrega un elemento al final del ArrayList.

            2) Insert: Inserta un elemento en una posición específica del ArrayList.

            3) Remove: Elimina la primera aparición de un elemento específico del ArrayList.

            4) RemoveAt: Elimina el elemento en la posición especificada del ArrayList.

            5) Clear: Elimina todos los elementos del ArrayList.

            6) Contains: Verifica si un elemento específico está presente en el ArrayList.

            7) IndexOf: Devuelve el índice de la primera aparición de un elemento específico en el ArrayList.

            8) Count: Devuelve la cantidad de elementos en el ArrayList.

            9) ToArray: Copia los elementos del ArrayList a un nuevo arreglo.

            10) Sort: Ordena los elementos del ArrayList en orden ascendente.

            11) Reverse: Invierte el orden de los elementos en el ArrayList.

            12) GetRange: Devuelve una nueva instancia de ArrayList que contiene una copia de una sección del ArrayList original.
            */

            //Creamos una instancia
            ArrayList palabras = new ArrayList();
            int i = 0;
            int n = 0;

            //Podemos adicionar con rango
            palabras.AddRange(new string[] {"hola", "como", "estas?"});//Pasamos una coleccion como parametro

            Console.WriteLine("La cantidad de elementos que contiene el ArrayList es de {0}", palabras.Count);

            //Imprimimos el ArrayList utilizando el ciclo for
            for(n = 0; n < palabras.Count; n++)
            {
                Console.Write("[{0}], ", palabras[n]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------");

            //Otra forma de adicionar elementos
            palabras.Add("Bien y tu?");

            foreach (string palabra in palabras)
            {
                Console.Write("[{0}], ", palabras[n]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------");

            ArrayList valores = new ArrayList();

            //Esta vez añadimos enteros
            valores.Add(5);
            valores.Add(7);
            valores.Add(4);

            //Recorresmos con el ciclo for
            for(n=0; n<valores.Count; n++)
            {
                i = (int)valores[n]; // El ArrayList devuelva un objeto de tipo object, por eso es necesario hacer un cast.
                Console.Write("[{0}], ", i); 
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------");

            //Chequeamos si un elemento existe dentro del ArrayList
            Console.WriteLine(valores.Contains(7));
            Console.WriteLine(valores.Contains(1));

            Console.WriteLine("----------");

            //Insertamos un elemento en un indice en particular
            valores.Insert(2, 55);

            for(n=0; n<valores.Count; n++)
            {
                i = (int)valores[n]; // El ArrayList devuelva un objeto de tipo object, por eso es necesario hacer un cast.
                Console.Write("[{0}], ", i); 
            }

            Console.WriteLine();
            Console.WriteLine("----------");

            //Eliminamos un elemento del ArrayList
            valores.Remove(55);

            for(n=0; n<valores.Count; n++)
            {
                i = (int)valores[n]; // El ArrayList devuelva un objeto de tipo object, por eso es necesario hacer un cast.
                Console.Write("[{0}], ", i); 
            }

            Console.WriteLine();
            Console.WriteLine("----------");

            //Eliminamos un elemento en un indice especifico
            valores.RemoveAt(0);

            for(n=0; n<valores.Count; n++)
            {
                i = (int)valores[n]; // El ArrayList devuelva un objeto de tipo object, por eso es necesario hacer un cast.
                Console.Write("[{0}], ", i); 
            }

            Console.WriteLine();
            Console.WriteLine("----------");
        }
    }
}
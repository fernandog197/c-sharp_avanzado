using System;
using System.Collections;

namespace CollectionsStack
{
    class Program
    {
        public static void Main ()
        {
            /*
            Stack es una colección que sigue la estructura de datos de pila (LIFO - Last-In-First-Out), lo que significa que el último elemento agregado es el primero en ser eliminado.

            Caracteristicas principales:
            _ Almacena elementos de cualquier tipo de datos y los trata como objetos.
            _ Permite agregar elementos al tope de la pila y eliminar el elemento más reciente agregado (desapilar).
            _ No se pueden acceder a los elementos intermedios directamente, solo se puede acceder al elemento en la cima de la pila.

            Metodos principales:
            1) Push: Agrega un elemento al tope de la pila.
            2) Pop: Elimina y devuelve el elemento más reciente agregado a la pila.
            3) Peek: Devuelve el elemento más reciente agregado a la pila sin eliminarlo.
            4) Count: Devuelve la cantidad de elementos en la pila.
            5) Clear: Elimina todos los elementos de la pila.
            */

            Stack stack = new Stack();// => LIFO

            //Agregamos elementos
            stack.Push("Manzana");
            stack.Push("Pera");
            stack.Push("Ciruela");
            stack.Push("Mango");

            //Iteramos en el stack
            foreach (string fruta in stack)
            {
                Console.Write("[{0}], ", fruta);
            }
            
            Console.WriteLine();
            Console.WriteLine("- - - - -");

            //Extraemos el siguiente elemento
            Console.WriteLine(stack.Pop());

            foreach (string fruta in stack)
            {
                Console.Write("[{0}], ", fruta);
            }
            
            Console.WriteLine();
            Console.WriteLine("- - - - -");

            //Obtenes el proximo elemento que saldra del Stack, sin extraerlo
            Console.WriteLine(stack.Peek());

            Console.WriteLine("- - - - -");

            //Obtenemos la cantidad de elementos del Stack
            Console.WriteLine("El stack contiene {0} elementos", stack.Count);

            Console.WriteLine("- - - - -");
        }
    }
}
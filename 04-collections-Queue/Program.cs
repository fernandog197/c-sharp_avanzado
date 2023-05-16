using System;
using System.Collections;

namespace Queue
{
    class Program
    {
        public static void Main ()
        {
            /*
            Una Queue es una estructura de datos en forma de cola (FIFO - First In, First Out) donde los elementos se insertan al final y se eliminan del principio.

            Caracteristicas principales:
            _ Los elementos se agregan al final de la cola (enqueue) y se eliminan del principio (dequeue).
            _ Sigue el principio FIFO, lo que significa que el primer elemento en entrar es el primero en salir.
            _ Se puede acceder al elemento que está en el frente de la cola sin eliminarlo (peek).
            _ Puede contener elementos de cualquier tipo.

            Metodos principales:
            1) Enqueue: Agrega un elemento al final de la cola.
            2) Dequeue: Elimina y devuelve el elemento que está al principio de la cola.
            3) Peek: Devuelve el elemento que está al principio de la cola sin eliminarlo.
            4) Count: Devuelve el número de elementos en la cola.
            5) Clear: Elimina todos los elementos de la cola.
            6) Contains: Verifica si un elemento específico está en la cola.
            7) ToArray: Copia los elementos de la cola a un nuevo arreglo.
            */

            Queue<string> queue = new Queue<string>();// => FIFO

            //Adicionamos objetos
            queue.Enqueue("Manzana");
            queue.Enqueue("Fresa");
            queue.Enqueue("Pera");

            //Iteramos
            foreach (string q in queue)
            {
                Console.Write("-> {0} ", q);
            }
            
            Console.WriteLine();
            Console.WriteLine("- - - - -");

            //Sacamos el primer elemento
            Console.WriteLine("Dequeue {0}", queue.Dequeue());
            Console.WriteLine("Dequeue {0}", queue.Dequeue());

            foreach (string q in queue)
            {
                Console.Write("-> {0} ", q);
            }
            
            Console.WriteLine();
            Console.WriteLine("- - - - -");

            //Adicionamos nuevos elementos
            queue.Enqueue("Limon");
            queue.Enqueue("Mango");
            queue.Enqueue("Ciruela");

            //Observamos el objeto Peek -> el siguiente elemente que saldra de la queue
            Console.WriteLine("Peek -> {0}", queue.Peek());

            foreach (string q in queue)
            {
                Console.Write("-> {0} ", q);
            }
            
            Console.WriteLine();
            Console.WriteLine("- - - - -");

            //Contamos la cantidad de elementos
            Console.WriteLine("Cantidad de elementos en queue: {0}", queue.Count);
            Console.WriteLine("- - - - -");

            //Verificamos si existe un elemento
            Console.WriteLine(queue.Contains("Limon"));
            Console.WriteLine(queue.Contains("Banana"));
            Console.WriteLine("- - - - -");
        }
    }
}
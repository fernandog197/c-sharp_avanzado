using System;
using System.Collections.Generic;

namespace CollectionsGenericsStacksQueue
{
    class Program
    {
        public static void Main ()
        {
            //STACK
            Console.WriteLine("STACK");

            Stack<CPoint> stackPoints = new Stack<CPoint>();

            stackPoints.Push(new CPoint(3, 4));
            stackPoints.Push(new CPoint(5, 7));
            stackPoints.Push(new CPoint(9, 11));
            stackPoints.Push(new CPoint(1, 4));

            foreach (CPoint sP in stackPoints)
            {
                Console.WriteLine("-> {0}", sP);
            }
            Console.WriteLine();

            //Hacemos un Peek
            Console.WriteLine("Peek");
            Console.WriteLine(stackPoints.Peek());
            Console.WriteLine();

            //Hacemos un Pop
            CPoint popPoint = stackPoints.Pop();
            Console.Write("Pop: " + popPoint);
            Console.WriteLine();

            //QUEUE
            Console.WriteLine("QUEUE");

            Queue<CPoint> queuePoints = new Queue<CPoint>();

            queuePoints.Enqueue(new CPoint(3, 4));
            queuePoints.Enqueue(new CPoint(5, 7));
            queuePoints.Enqueue(new CPoint(9, 11));
            queuePoints.Enqueue(new CPoint(1, 4));

            foreach (CPoint qP in queuePoints)
            {
                Console.WriteLine("-> {0}", qP);
            }
            Console.WriteLine();

            //Hacemos un Peek
            Console.WriteLine("Peek");
            Console.WriteLine(queuePoints.Peek());
            Console.WriteLine();

            //Hacemos un Dequeue
            CPoint dequeuePoint = queuePoints.Dequeue();
            Console.Write("Dequeue: " + dequeuePoint);
            Console.WriteLine();
        }
    }
}
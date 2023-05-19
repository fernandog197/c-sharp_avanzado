using System;
using System.Collections.Generic;

namespace CollectionsGenericSortedSet
{
    class Program
    {
        public static void Main ()
        {
            SortedSet<CPoint> sortedSetPoint = new SortedSet<CPoint>();

            sortedSetPoint.Add(new CPoint(3, 7));
            sortedSetPoint.Add(new CPoint(8, 11));
            sortedSetPoint.Add(new CPoint(2, 6));

            foreach (CPoint p in sortedSetPoint)
            {
                Console.WriteLine("<<{0}>>", p);
            }

            Console.WriteLine("- - - - -");

            sortedSetPoint.Add(new CPoint(1, 15));
            sortedSetPoint.Add(new CPoint(1, 2));

            foreach (CPoint p in sortedSetPoint)
            {
                Console.WriteLine("<<{0}>>", p);
            }

            Console.WriteLine("- - - - -");
        }
    }
}
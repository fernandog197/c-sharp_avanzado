namespace GenericClass
{
    class Program
    {
        public static void Main ()
        {
            //Para pointI, CPoint trabaja con int
            CPoint<int> pointI = new CPoint<int>(3, 4);

            //Para pointD, CPoint trabaja con double
            CPoint<double> pointD = new CPoint<double>(2.56, 1.87);

            //Para pointF, CPoint trabaja con float
            CPoint<float> pointF = new CPoint<float>(8.98f, 7.69f);

            Console.WriteLine(pointI);
            Console.WriteLine(pointD);
            Console.WriteLine(pointF);

            //Regresamos pointI a su valor por defecto
            pointI.Reset();
            Console.WriteLine(pointI);

            //Verificamos si estamos trabajando con Int
            pointI.TypeFounder();
            pointD.TypeFounder();
        }
    }
}
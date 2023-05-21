namespace LambdaExpressions
{
    /*
    En términos simples, una expresión lambda es una forma concisa de escribir funciones anónimas, es decir, funciones sin un nombre definido.

    Las expresiones lambda se utilizan para crear funciones de manera rápida y compacta. Tienen la siguiente sintaxis general:
    (parametros) => expresion

    Al igual que las funciones flecha en JavaScript, las expresiones lambda en C# ofrecen varias ventajas, como:

    1) Sintaxis concisa: Las expresiones lambda permiten escribir funciones de manera más compacta, lo que facilita la lectura y el mantenimiento del código.

    2) Captura automática del contexto: Las expresiones lambda pueden acceder automáticamente a las variables locales y parámetros del ámbito en el que se definen, lo que las hace convenientes para la programación asíncrona y la manipulación de colecciones.

    3) Uso en métodos de orden superior: Las expresiones lambda se utilizan ampliamente en métodos de orden superior, como Where, Select, OrderBy, entre otros, para especificar la lógica de filtrado, proyección o clasificación de datos.
    */
    class Program
    {
        public static void Main ()
        {
            List<int> intList = new List<int>();
            intList.AddRange(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});

            //Hacemos uso de la expresion Lambda
            List<int> evenNumbers = intList.FindAll(i => i%2 == 0);

            PrintList(intList);
            Console.WriteLine();

            PrintList(evenNumbers);
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
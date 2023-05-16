using System;
using System.Collections;

namespace CollectionsArrayBit
{
    class Program
    {
        public static void Main ()
        {
            /*
            El BitArray es una estructura de datos en C# que representa una colección de bits compactos, es decir, una secuencia de valores booleanos (true/false) almacenados de forma eficiente en la memoria. A diferencia de los ArrayList, que almacenan cualquier tipo de objeto, el BitArray se especializa en trabajar con bits individuales y permite operaciones bit a bit de manera eficiente.

            Características principales del BitArray:

            _ Almacena una secuencia de bits (true/false) en un arreglo compacto.
            _ Cada bit ocupa solo 1 bit de memoria, en contraste con un bool que normalmente ocupa 1 byte (8 bits) de memoria.
            _ Permite realizar operaciones bit a bit, como AND, OR, NOT, XOR, desplazamientos y más.
            _ Puede utilizarse para representar conjuntos de elementos donde cada elemento está asociado con un solo bit (por ejemplo, marcar la presencia o ausencia de un elemento).
            
            Algunos de los métodos más utilizados en BitArray son:

            1) BitArray(int length): Constructor que crea un nuevo BitArray con la longitud especificada.
            2) his[int index]: Propiedad indexadora que permite acceder y modificar el valor de un bit en la posición especificada.
            3) Length: Propiedad que devuelve la longitud (cantidad de bits) del BitArray.
            4) And(BitArray value): Realiza una operación AND bit a bit entre dos BitArray, modificando el BitArray original.
            5) Or(BitArray value): Realiza una operación OR bit a bit entre dos BitArray, modificando el BitArray original.
            6) Not(): Realiza una operación NOT bit a bit en el BitArray, modificando el BitArray original.
            7) Xor(BitArray value): Realiza una operación XOR bit a bit entre dos BitArray, modificando el BitArray original.
            8) SetAll(bool value): Establece todos los bits del BitArray en el valor especificado (true/false).
            9) CopyTo(Array array, int index): Copia los bits del BitArray a un arreglo unidimensional de tipo Array, comenzando en la posición especificada.
            */

            BitArray bitArray = new BitArray(new byte[] {1, 2, 4, 8, 16});

            //Cantidad de elementos , 5bytes * 8 = 40bits.
            Console.WriteLine(bitArray.Count);
            MuestraArreglo(bitArray, "bitArray");

            Console.WriteLine("- - - - -");

            //Obtener un bit en particular
            Console.WriteLine(bitArray.Get(3));

            //Colocamos un bit en particular
            bitArray.Set(3, true);
            MuestraArreglo(bitArray);
            Console.WriteLine(bitArray.Get(3));

            Console.WriteLine("- - - - -");

            //Clonamos nuestro BitArray
            BitArray bitArray02 = (BitArray) bitArray.Clone();
            MuestraArreglo(bitArray02, "bitArray02");

            Console.WriteLine("- - - - -");

            //Invertimos el arreglo con NOT
            bitArray02.Not();
            MuestraArreglo(bitArray02, "bitArray02 -> Not");

            //Creamos un nuevo BitArray
            BitArray bitArray03 = new BitArray(new byte[] {5, 7, 9, 13, 15});
            Console.WriteLine("bitArray03 antes del OR");
            MuestraArreglo(bitArray03, "bitArray03");

            Console.WriteLine("- - - - -");

            //Llevamos a cabo el OR entre arreglos
            bitArray03.Or(bitArray); //=> el resultado se guarda en el BitArray que invoca el metodo, en este caso bitArray03
            MuestraArreglo(bitArray, "bitArray");
            MuestraArreglo(bitArray03, "bitArray03");

            Console.WriteLine("= = = = =");

            //De manera analoga, hacemos uso de la operacion AND

            //Imprimimos los BitArrays para poder compararlos
            Console.WriteLine("bitArray y bitArray03 antes del AND");
            MuestraArreglo(bitArray, "bitArray");
            MuestraArreglo(bitArray03, "bitArray03");
            Console.WriteLine("= = = = =");

            bitArray03.And(bitArray); //=> el resultado se guarda en el BitArray que invoca el metodo, en este caso bitArray03
            Console.WriteLine("bitArray03 despues del AND");
            MuestraArreglo(bitArray03, "bitArray03");
            Console.WriteLine("= = = = =");

            //Ahora aplicamos XOR a bitArray03 => XOR devuelve true si a != b
            bitArray03.Xor(bitArray);
            Console.WriteLine("bitArray03 despues del XOR");
            MuestraArreglo(bitArray03, "bitArray03");

        }

        public static void MuestraArreglo (BitArray bitArray, string name = "")
        {
            int c = 0;

            Console.Write("{0}\t", name);

            foreach (bool b in bitArray)
            {
                c++;

                if(b)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }

                if(c%8 == 0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
namespace AnonymousTypes
{
    /*
    Los tipos anónimos en C# son una característica que te permite crear objetos sin tener que definir una clase explícita. Son útiles cuando necesitas crear objetos temporales o simples sin la necesidad de definir una estructura completa.

    La sintaxis para crear un tipo anónimo es la siguiente:
    var objetoAnonimo = new { Propiedad1 = valor1, Propiedad2 = valor2, ... };

    Los tipos anónimos son útiles cuando necesitas agrupar datos relacionados de forma temporal, como resultados de una consulta o datos provenientes de múltiples fuentes. Puedes acceder a las propiedades del tipo anónimo utilizando la notación de punto, por ejemplo: objetoAnonimo.Propiedad1.
    */
    class Program
    {
        public static void Main ()
        {
            //Creamos el tipo anonimo
            var myPC = new { Procesador = "i7", Memoria = 16, Graficos = "Integrada Intel"};

            //Imprimimos la variable
            Console.WriteLine(myPC);

            //Podemos acceder a un atributo en especifico
            Console.WriteLine("Mi PC tiene {0} de memoria RAM.", myPC.Memoria);

            //NO podemos modificar los atributos! Es de solo lectura.
            //myPC.Memoria = 24; => esto no esta permitido.

            
        }
    }
}
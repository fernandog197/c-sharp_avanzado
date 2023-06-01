namespace DynamicPart02
{
    class Program
    {
        public static void Main ()
        {
            //Forma de invocar a miembros cuando se utiliza Dynamic

            //Creamos una cadena con Dynamic
            dynamic texto = "elementos";

            //Podemos obtener una propiedad del tipo
            int size = texto.Length; //-> Notar que NO funciona el IntelliSense!!!

            //Podemos invocar un metodo
            texto = texto.ToUpper(); //-> Notar que NO funciona el IntelliSense!!!

            Console.WriteLine("{0}, {1}", texto, size);

            //Dynamic, al no ser fuertemente tipificado, NO permite el uso de IntelliSense, por ende, no se verifica el error de sintaxis en el momento de compilacion.
            //El error tampoco aparecera cuando se ejecute
            // - > size = texto.length; 

            //Incluso podemos invocar metodos que no existe y esto no se reflejara en el compilador
            // -> texto.nono(57);

            //Ambos errores aparecen como Exceptions al momento de ejecutar el programa

            //FORMA CORRECTA DE UTILIZAR DYNAMIC
            dynamic texto2 = "Miguel";

            try
            {
                int n = texto2.Length;
                texto2.ToUpper();
                Console.WriteLine("{0}, {1}", texto2, n);
                //texto2.toupper();

                DynamicClass objeto = new DynamicClass();

                objeto.Atributo = 5;
                objeto.Print();

                objeto.Atributo = "Nuevo valor";
                objeto.Print();

                objeto.GetDynamic(57.5);
                objeto.GetDynamic("Otro test");

                dynamic retorno = objeto.ReturnDynamic(10);
                Console.WriteLine(retorno);
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
            }
        }
    }
}
namespace Var
{
    class Program
    {
        public static void Main ()
        {
            /*
            _ Declaracion implicita de variables
            _ Solo se permiten en variables locales
            _ No se pueden usar en atributos
            _ Nose pueden usar como tipos de retorno
            _ Se debe colocar un valor en el momento de declaracion y no puede ser null
            _ No confundir con var o Variant de otros lenguajes, es fuertemente tipificado
            _ Se usan en LinQ, donde un query puede dar un resultado dinamicamente creado
            */

            var a = 5;
            var b = "Hola a todos";
            var c = 1256.3435;
            var d = false;
            //var e =null; => Al momento crearse la variable SI o SI debe asignarsele un valor
            //d = 58; => No puede haber cambio de tipo una vez la variable fue creada
            var f = c;

            //Imprimimos
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            //Usamos reflexion para conocer el tipo
            Console.WriteLine("a es {0}", a.GetType().Name);
            Console.WriteLine("b es {0}", b.GetType().Name);
            Console.WriteLine("c es {0}", c.GetType().Name);
            Console.WriteLine("d es {0}", d.GetType().Name);
            Console.WriteLine("f es {0} -> {1}", f.GetType().Name, f);

            Console.WriteLine("- - - - - - - - -");
        }
    }
}
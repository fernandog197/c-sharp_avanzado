//Agregamos los namespaces para poder usar los tipos definidos en su contexto
using LasClases;
using OtrasClases;

//Aqui creamos el alias
using principal = LasClases.Clase01;
using secundaria = OtrasClases.Clase01;

//Creamos alias para clases anidadas
using Terciaria = Namespaces.ClasesAnidadas.Clase03;// -> Asi accedemos en namespaces anidados
using Cuaternaria = LasClases.Clase03;

namespace Namespaces
{
    class Program
    {
        public static void Main ()
        {
            //Las clases de cierto namespace, solo se pueden utilizar si accedemos a ese namespace con using
            //Clase01 obj01 = new Clase01();

            //Otra forma es utilizar el nombre totalmente calificado. Esto funciona si los namespaces se encuentran dentro del 
            //mismo proyecto
            //LasClases.Clase02 obj02 = new Clase02();

            //Al adicionar otro namespace, se generan conflictos porque existen clases con el mismo nombre
            //Estas pueden resolverse utilizando el nombre totalmente calificado
            LasClases.Clase02 obj03 = new LasClases.Clase02();
            OtrasClases.Clase02 obj04 = new OtrasClases.Clase02();

            //Otro metodo es utilizar un "sobrenombre" para las clases en conflicto
            principal obj05 = new principal();
            secundaria obj06 = new secundaria();

            //Tambien es posible anidar namespaces (esto es namespaces dentro de otro namespace). Para acceder a sus elementos
            //simplemente utilizamos alias o su nombre totalmente calificado, teniendo en cuenta el orden del anidamiento.
            Terciaria obj07 = new Terciaria();
            Cuaternaria obj08 = new Cuaternaria();
        }
    }
}
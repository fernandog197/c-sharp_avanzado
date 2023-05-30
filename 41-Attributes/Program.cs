using System;

//En este nivel se colocan los atributos que se aplicaran a todos los elementos
[assembly: CLSCompliant(true)]

namespace Attributes
{
    /*
        Los atributos (Attributes) en C# son una característica del lenguaje que permiten adjuntar metadatos a tipos, miembros o ensamblados en tiempo de compilación. Los atributos se representan mediante clases que heredan de la clase base System.Attribute.

        Algunas características y aplicaciones comunes de los atributos son:

        1) Metadatos y anotaciones: Los atributos se utilizan para agregar metadatos o anotaciones a los elementos del código. Puedes utilizar atributos para proporcionar información adicional sobre clases, métodos, propiedades, parámetros, etc. Esto puede ser útil para documentar, configurar o controlar el comportamiento de tu código.

        2) Reflexión y tiempo de ejecución: Los atributos se pueden consultar en tiempo de ejecución utilizando la reflexión. Esto te permite examinar y tomar decisiones basadas en los atributos adjuntos a los elementos del código. Por ejemplo, puedes usar atributos para implementar la lógica personalizada en un marco de trabajo o para modificar el comportamiento de tu aplicación.

        3) Decoración de código: Los atributos se pueden utilizar para decorar y personalizar el código. Puedes agregar atributos a clases, métodos o propiedades para indicar información adicional o para influir en cómo se compila o se ejecuta el código. Por ejemplo, el atributo [Obsolete] se utiliza para marcar elementos que están en desuso y que deben evitarse.

        4) Serialización y persistencia: Algunos atributos se utilizan para controlar la serialización y persistencia de objetos. Por ejemplo, el atributo [Serializable] se utiliza para indicar que una clase se puede serializar y almacenar en un formato persistente.
    */
    class Program
    {
        public static void Main ()
        {
            /*
                || Attributes ||
                _ Adicionan informacion al metadta del Assembly
                _ Se pueden utilizar con clases, interfaces, estructuras, propiedades, metodos.
                _ Son clases que descienden de System.Attribute
                _ Ej: [CLSCompliant], [Obsolete], [Serializable], [NonSerializable]
                _ El compilador esta preparado para encontrar los atributos y actuar con lo que se deba presentar el mismo
                _ Tienen un nombre corto y uno largo: [Serializable] -> [SerializableAttribute]
                _ Pueden o no recibir parametros, dependiendo de sus constructores
            */

            CPrueba prueba01 = new CPrueba();
            CPrueba02 prueba02 = new CPrueba02();
        }
    }
}
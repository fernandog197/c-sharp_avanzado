using System;
using System.Reflection;

/*
    La Reflection en C# es una característica que permite examinar y manipular tipos, objetos y miembros en tiempo de ejecución. Proporciona información detallada sobre los tipos y permite realizar operaciones dinámicas, como crear instancias, llamar a métodos, acceder y modificar propiedades, entre otros, sin conocer los detalles en tiempo de compilación.

    La Reflection es útil en situaciones en las que necesitas acceder y manipular tipos y miembros en tiempo de ejecución, como en la creación de bibliotecas de complementos, en la serialización y deserialización de objetos, en la generación dinámica de código, en la inspección de ensamblados, entre otros escenarios.

    * Metodos comunes al trabajar con Reflection
    1) GetType(): Obtiene el objeto Type de un tipo específico.

    2) GetProperties(): Obtiene las propiedades públicas de un tipo.

    3) GetFields(): Obtiene los campos públicos de un tipo.

    4) GetMethods(): Obtiene los métodos públicos de un tipo.

    5) GetConstructors(): Obtiene los constructores públicos de un tipo.

    6) GetProperty(string name): Obtiene una propiedad específica por su nombre.

    7) GetField(string name): Obtiene un campo específico por su nombre.

    8) GetMethod(string name): Obtiene un método específico por su nombre.

    9) GetConstructor(Type[] parameterTypes): Obtiene un constructor específico según los tipos de parámetros.

    10) Invoke(object obj, object[] parameters): Invoca un método en un objeto específico con los parámetros proporcionados.

    11) SetValue(object obj, object value): Establece el valor de una propiedad o campo en un objeto específico.

    12) GetValue(object obj): Obtiene el valor de una propiedad o campo en un objeto específico.

    13) CreateInstance(Type type): Crea una instancia de un tipo utilizando el constructor predeterminado.

    14) IsAssignableFrom(Type type): Comprueba si un tipo es asignable desde otro tipo.

    15) IsSubclassOf(Type type): Comprueba si un tipo es una subclase de otro tipo.

    *Seguridad
    Al utilizar Reflection, es importante tener en cuenta el rendimiento y la seguridad, ya que la reflexión puede tener un impacto en el rendimiento y también puede acceder a miembros privados que normalmente no se podrían acceder directamente.

    Es posible evitar el acceso a miembros privados utilizando mecanismos de seguridad y buenas prácticas en tu código. Aquí hay algunas sugerencias:

    1) Modificadores de acceso adecuados: Utiliza los modificadores de acceso adecuados en tus clases y miembros. Marca los miembros como 2) private cuando solo necesiten ser accedidos internamente por la propia clase. Esto ayuda a limitar el acceso a los miembros privados solo dentro del ámbito apropiado.

    2) Encapsulación: Utiliza la encapsulación para ocultar detalles internos y exponer solo la interfaz necesaria. Define propiedades y métodos públicos que ofrezcan acceso controlado a los datos y funcionalidades subyacentes. Esto permite que los miembros privados no sean accesibles directamente desde fuera de la clase.

    3) Restricciones de acceso: Utiliza atributos y directivas de compilador para restringir el acceso a miembros privados. Por ejemplo, en C#, puedes usar el atributo internal para limitar el acceso a nivel de ensamblado, asegurando que solo las clases dentro del mismo ensamblado puedan acceder a los miembros marcados como internal.

    4) ReflectionPermission: Puedes utilizar el espacio de nombres System.Security.Permissions y el tipo ReflectionPermission para otorgar o denegar permisos específicos de reflexión en tu aplicación. Esto te permite controlar qué código tiene permiso para utilizar Reflection y acceder a los miembros privados.

    5) Análisis de código estático: Utiliza herramientas de análisis de código estático para detectar posibles problemas de acceso a miembros privados. Estas herramientas pueden ayudarte a identificar lugares en tu código donde se está accediendo a miembros privados de manera incorrecta o insegura.
*/

namespace Reflection
{
    class Program
    {
        public static void Main()
        {
            // Obtener el tipo de la clase Person
            Type personType = typeof(Person);
            
            // Obtener las propiedades de la clase
            PropertyInfo[] properties = personType.GetProperties();
            
            Console.WriteLine("Propiedades de la clase Person:");
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }
            
            // Obtener los métodos de la clase
            MethodInfo[] methods = personType.GetMethods();
            
            Console.WriteLine("\nMétodos de la clase Person:");
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
            
            // Crear una instancia de la clase Person
            var person = Activator.CreateInstance(personType);
            
            // Establecer el valor de la propiedad "Name"
            PropertyInfo nameProperty = personType.GetProperty("Name");
            nameProperty.SetValue(person, "John Doe");
            
            // Establecer el valor de la propiedad "Age"
            PropertyInfo ageProperty = personType.GetProperty("Age");
            ageProperty.SetValue(person, 30);
            
            // Invocar el método "SayHello"
            MethodInfo sayHelloMethod = personType.GetMethod("SayHello");
            sayHelloMethod.Invoke(person, null);
        }
    }
}
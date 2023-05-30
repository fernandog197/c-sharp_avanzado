namespace Attributes
{
    //La clase debe ser publica y sellada
    //Este atributo guarda el dato en el Assembly

    public sealed class DatosAttribute : System.Attribute
    {
        string dato;

        public string Dato { get => this.dato; set => this.dato = value; }

        public DatosAttribute ()
        {
            this.dato = "";
        }

        public DatosAttribute (string dato)
        {
            this.dato = dato;
        }
    }

    //Podemos agregar en un enum los targets de nuestro atributo
    // public enum AttributeTargets
    // {
    //     All, Assembly, Class, Constructor,
    //     Delegate, Enum, Event, Field, GenericParameter,
    //     Interface, Method, Module, Parameter,
    //     Property, ReturnValue, Struct
    // }
    // [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
}
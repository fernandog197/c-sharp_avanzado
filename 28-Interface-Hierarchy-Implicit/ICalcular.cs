namespace InterfacesHierarchyImplicit
{
    //Creamos jerarquia de Interfaces. Ahora ICalcular tiene los metodos de IMostrar.
    interface ICalcular : IMostrar
    {
        int Calculo (int a, int b);
    }
}
namespace InterfacesHierarchyImplicit
{
    class Program
    {
        public static void Main ()
        {
            //Implementamos 2 interfaces distintas que contienen un metodo con el mismo nombre
            CCuadrado cuadrado = new CCuadrado(5);

            ((IPerimetro)cuadrado).Calcular();
            ((IArea)cuadrado).Calcular();

            //JERARQUIA DE INTERFACES
            CSuma miSuma = new CSuma();

            //Metodo derivado de ICalcular
            miSuma.Calculo(2, 5);

            //Metodo derivado de IMostrar
            miSuma.MostrarDatos();
        }
    }
}
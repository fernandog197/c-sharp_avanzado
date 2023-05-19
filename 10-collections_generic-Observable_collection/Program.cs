using System;
using System.Collections.ObjectModel; //NO olvidar este using!

namespace CollectionsGenericObservableCollection
{
    /*
    ObservableCollection es una clase en el espacio de nombres System.Collections.ObjectModel que implementa la interfaz ICollection<T> y notifica automáticamente los cambios realizados en la colección a través de eventos. Aquí tienes algunas características clave y métodos principales de ObservableCollection:

    Características:
    _ Notificación de cambios: ObservableCollection genera eventos cuando se agregan, eliminan o modifican elementos en la colección, lo que permite a los suscriptores estar al tanto de los cambios.
    
    Métodos principales:
    1) Add: Agrega un elemento al final de la colección.
    2) Remove: Elimina la primera aparición del elemento especificado de la colección.
    3) Clear: Elimina todos los elementos de la colección.
    4) Contains: Determina si un elemento específico se encuentra en la colección.
    5) Count: Obtiene el número de elementos en la colección.
    6) IndexOf: Devuelve el índice de la primera aparición de un elemento en la colección.
    7) Insert: Inserta un elemento en la posición especificada de la colección.
    8) RemoveAt: Elimina el elemento en el índice especificado de la colección.
    
    Estos son solo algunos de los métodos más comunes de ObservableCollection. Además de estos, también hereda los métodos de la interfaz ICollection<T>.
    ObservableCollection es especialmente útil cuando necesitas mantener sincronizada una colección con la interfaz de usuario, como en aplicaciones WPF o Windows Forms, donde los cambios en la colección deben reflejarse automáticamente en los elementos visuales correspondientes.  
    */
    class Program
    {
        public static void Main ()
        {
            ObservableCollection<CPoint> observableCollection = new ObservableCollection<CPoint>()
            {
                new CPoint(4, 55), new CPoint(17, 22)
            };

            //Adicionamos el handler
            observableCollection.CollectionChanged += observableCollection_CollectionChanged;

            observableCollection.Add(new CPoint(2, 3));

            CPoint myPoint = new CPoint(5, 5);

            observableCollection.Add(myPoint);

            observableCollection.Remove(myPoint);
        }

        //Este es el handler que se invoca cuando cambia la coleccion
        static void observableCollection_CollectionChanged (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //Vemos el tipo de evento que ocurrio
            Console.WriteLine("El evento es {0}", e.Action);

            //Si la accion es Adicionar
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Elementos nuevos!");
                foreach (CPoint p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }

            //Si el tipo de evento fue Remover
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Elementos afectados por el cambio");
                foreach (CPoint p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
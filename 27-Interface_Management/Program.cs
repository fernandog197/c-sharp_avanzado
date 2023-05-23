namespace InterfaceManagement
{
    class Program
    {
        public static void Main ()
        {
            //Arreglo de interfaces

            IElectronico[] electros = { new CTelevisor("Lenovo"), new CTelevisor("Zorny"), new CRadio("Philipz") };
            IElectronico aparatoCreado = null;

            for(int n = 0; n < electros.Length; n++)
            {
                Console.WriteLine(electros[n]);
            }

            Console.WriteLine("- - - - -");

            //Uso de interfaces con metodos
            CTelevisor newTV = new CTelevisor("Samsung");
            CRadio newRadio = new CRadio("ABC Radio");

            Muestra(newTV);
            Muestra(newRadio);

            Console.WriteLine("- - - - -");

            //Metodo que regresa objeto que implementa la interface
            aparatoCreado = CrearAparato();
            aparatoCreado.Encender(true);
            Console.WriteLine(aparatoCreado);
        }

        static void Muestra (IElectronico aparato)
        {
            if(aparato is CTelevisor)
            {
                Console.WriteLine("Su aparato es un televisor: {0}", aparato);
            }

            if(aparato is CRadio)
            {
                Console.WriteLine("Su aparato es una Radio: {0}", aparato);
            }
        }

        static IElectronico CrearAparato ()
        {
            IElectronico newAparato = null;
            string dato = string.Empty;
            int opcion = 0;

            Console.WriteLine("Que desea crear? 1-Televisor | 2-Radio");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            if(opcion == 1)
            {
                Console.WriteLine("Por favor, escriba la marca del televisor.");
                dato = Console.ReadLine();
                newAparato = new CTelevisor(dato);
            }

            if(opcion == 2)
            {
                Console.WriteLine("Por favor, escriba la marca del radio.");
                dato = Console.ReadLine();
                newAparato = new CRadio(dato);
            }

            return newAparato;
        }
    }
}
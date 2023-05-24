namespace Exceptions03
{
    class CCaldera
    {
        private int max;
        private int temperaturaActual;
        private string marca;
        private bool funciona;

        public int TemperaturaActual { get => this.temperaturaActual; set => this.temperaturaActual = value; }
        public string Marca { get => this.marca; set => this.marca = value; }
        public bool Funciona { get => this.funciona; set => this.funciona = value; }

        public CCaldera (string marca, int temp)
        {
            this.max = 120;
            this.funciona = true;
            this.marca = marca;
            temperaturaActual = temp;
        }

        //V4 => Añadimos informacion relevante sobre la excepcion
        public void Trabajar (int Aumento)
        {
            if(funciona == false)
            {
                Console.WriteLine("La caldera {0} esta descompuesta", this.marca);
            }
            else
            {
                this.temperaturaActual += Aumento;
                Console.WriteLine("La temperatura actual es de {0}°", this.TemperaturaActual);

                if(this.temperaturaActual > this.max)
                {
                    Console.WriteLine("{0} supero su temperatura maxima! Temperatura actual: {1}", this.marca, this.temperaturaActual);
                    this.temperaturaActual = this.max;
                    this.funciona = false;

                    //Primera version de la excepcion propia. Creamos una instancia de nuestra clase Excepcion
                    CalderaException calderaException = new CalderaException(string.Format("La caldera {0} se ha sobrecalentado", this.marca),
                    "Ha trabajado demasiado tiempo",
                    DateTime.Now);

                    //Colocamos un link de ayuda
                    calderaException.HelpLink = "www.google.com";

                    //Lanzamos nuestra excepcion
                    throw calderaException;
                }
            }
        }
    }

    // public class CalderaException : ApplicationException
    // {
    //     private string mensaje;
    //     private DateTime momento;
    //     private string causa;

    //     public DateTime Momento { get => this.momento; set => this.momento = value; }
    //     public string Causa { get => this.causa; set => this.causa = value; }

    //     public CalderaException (string mensaje, string causa, DateTime momento) : base(mensaje)
    //     {
    //         this.mensaje = mensaje;
    //         this.causa = causa;
    //         this.momento = momento;
    //     }
    // }

    /*
        <<| Excepcion completa de acuerdo a las reglas de .NET |>>
        1) Derivar de Exception/ApplicationException
        2) Usar [System.Serializable]
        3) Definir constructor default
        4) Definir constructor que coloca Message en la herencia
        5) Definir constructor que maneja excepciones internas
        6) Definir constructor que maneja la serializacion del tipo
    */
    [Serializable]
    public class CalderaException : ApplicationException
    {
        public CalderaException () { }
        public CalderaException (string mensaje) : base(mensaje) { }
        public CalderaException (string mensaje, System.Exception inner) : base (mensaje, inner) { }
        protected CalderaException (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
                                    : base(info, context) { }

        //Aqui van propiedades adicionales
        private DateTime momento;
        private string causa;

        public DateTime Momento { get => this.momento; set => this.momento = value; }
        public string Causa { get => this.causa; set => this.causa = value; }

        public CalderaException (string mensaje, string causa, DateTime momento) : base(mensaje)
        {
            this.causa = causa;
            this.momento = momento;
        } 
    }
}
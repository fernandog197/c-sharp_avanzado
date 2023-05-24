namespace Exceptions01
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

        //Vamos a generar diferentes versiones del metodo Trabajar

        // //V1 => Sin usar excepciones
        // public void Trabajar (int Aumento)
        // {
        //     if(funciona == false)
        //     {
        //         Console.WriteLine("La caldera {0} esta descompuesta", this.marca);
        //     }
        //     else
        //     {
        //         this.temperaturaActual += Aumento;
        //         Console.WriteLine("La temperatura actual es de {0}°", this.TemperaturaActual);

        //         if(this.temperaturaActual > this.max)
        //         {
        //             Console.WriteLine("{0} supero su temperatura maxima! Temperatura actual: {1}", this.marca, this.temperaturaActual);
        //             this.temperaturaActual = this.max;
        //             this.funciona = false;
        //         }
        //     }
        // }

        // //V2 => Levantamos una excepcion cuando ocurre un problema
        // public void Trabajar (int Aumento)
        // {
        //     if(funciona == false)
        //     {
        //         Console.WriteLine("La caldera {0} esta descompuesta", this.marca);
        //     }
        //     else
        //     {
        //         this.temperaturaActual += Aumento;
        //         Console.WriteLine("La temperatura actual es de {0}°", this.TemperaturaActual);

        //         if(this.temperaturaActual > this.max)
        //         {
        //             Console.WriteLine("{0} supero su temperatura maxima! Temperatura actual: {1}", this.marca, this.temperaturaActual);
        //             this.temperaturaActual = this.max;
        //             this.funciona = false;

        //             //Lanzamos la excepcion
        //             throw new Exception(string.Format("La caldera {0} se sobrecalienta", this.marca));


        //         }
        //     }
        // }

        //V3 => Añadimos informacion propia a la Excepcion
        // public void Trabajar (int Aumento)
        // {
        //     if(funciona == false)
        //     {
        //         Console.WriteLine("La caldera {0} esta descompuesta", this.marca);
        //     }
        //     else
        //     {
        //         this.temperaturaActual += Aumento;
        //         Console.WriteLine("La temperatura actual es de {0}°", this.TemperaturaActual);

        //         if(this.temperaturaActual > this.max)
        //         {
        //             Console.WriteLine("{0} supero su temperatura maxima! Temperatura actual: {1}", this.marca, this.temperaturaActual);
        //             this.temperaturaActual = this.max;
        //             this.funciona = false;

        //             //Lanzamos la excepcion
        //             //Ahora tenemos una variable para la instancia
        //             Exception exception = new Exception(string.Format("La caldera {0} se sobrecalienta", this.marca));
        //             exception.HelpLink = "https://miguelgarcia-portfolio-miguedev.vercel.app/";

        //             throw exception;
        //         }
        //     }
        // }

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

                    //Lanzamos la excepcion
                    //Ahora tenemos una variable para la instancia
                    Exception exception = new Exception(string.Format("La caldera {0} se sobrecalienta", this.marca));
                    exception.HelpLink = "https://miguelgarcia-portfolio-miguedev.vercel.app/";

                    //Adicionamos datos propios a la excepcion
                    exception.Data.Add("Momento: ", string.Format("Ocurrio en {0}", DateTime.Now));
                    exception.Data.Add("Temperatura actual: ", string.Format("{0}°C", this.TemperaturaActual));
                    exception.Data.Add("Incremento dado: ", string.Format("{0}°C", Aumento));

                    throw exception;
                }
            }
        }
    }
}
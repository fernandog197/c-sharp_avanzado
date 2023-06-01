namespace DynamicPart02
{
    class DynamicClass
    {
        //Atributo con dynamic
        private dynamic atributo;

        //Get & Set con dynamic
        public dynamic Atributo { get => this.atributo; set => this.atributo = value; }

        public void Print ()
        {
            Console.WriteLine(this.atributo);
        }

        public void GetDynamic (dynamic parametro)
        {
            Console.WriteLine("Recibi: {0}", parametro);
        }

        public dynamic ReturnDynamic (int a)
        {
            if (a < 0)
            {
                return 5;
            }
            else
            {
                return "Positivo";
            }
        }
    }
}
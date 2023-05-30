namespace AritmeticaAttribute
{
    [Datos("Mi clase Matematicas")]
    public class Operaciones
    {
        private double a;
        private double b;
        private double r;

        public Operaciones (double a, double b)
        {
            this.a = a;
            this.b = b;
            this.r = 0.0;
        }

        public double R { get => this.r; }

        public double Suma ()
        {
            this.r = this.a + this.b;
            return R;
        }

        public double Resta ()
        {
            this.r = this.a - this.b;
            return R;
        }

        public double Multiplicacion ()
        {
            this.r = this.a * this.b;
            return R;
        }

        public double Division ()
        {
            this.r = this.a / this.b;
            return R;
        }
    }

    [Datos("Clase prueba 01")]
    public class CPrueba01
    {
        public CPrueba01()
        {
            Console.WriteLine("Version 01");
        }
    }

    [Datos("Clase prueba 02")]
    public class CPrueba02
    {
        public CPrueba02()
        {
            Console.WriteLine("Version 02");
        }
    }

    //Clase para el Attribute
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
}

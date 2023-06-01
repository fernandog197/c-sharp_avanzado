using System;

namespace LibraryTiposPlugin
{
    public interface IPlugInMates
    {
        double Calcular (double a, double b);
    }

    //Indicamos que el atributo se utilizara solo con clases
    [AttributeUsage(AttributeTargets.Class)]
    //Creamos un atributo para proveer informacion del plug-in
    public sealed class CInfoPlugIn : System.Attribute
    {
        private string creator;
        private string information;

        public string Creator { get => this.creator; set => this.creator = value; }
        public string Information { get => this.information; set => this.information = value; }
    }
}
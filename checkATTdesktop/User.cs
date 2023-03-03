using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop
{
    internal class User
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
    

        public User(string nombre, string apellido, string dni, string telefono, string correo, string direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Direccion = direccion;
        }

    }
}

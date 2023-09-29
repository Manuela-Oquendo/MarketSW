using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto
{
    internal class Alumno
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ocupacion { get; set; }

        public Alumno(string cedula, string nombre, string apellido, string direccion, string telefono, string ocupacion)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Ocupacion = ocupacion;
        }

        public override string ToString()
        {
            return $"Alumno: {Nombre} {Apellido}, Cédula: {Cedula}, Teléfono: {Telefono}, Ocupación: {Ocupacion}";
        }
    }
}

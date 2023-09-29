using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto
{
    public class Curso
    {

        public string Nombre { get; set; }
        public string Contenido { get; set; }
        public int Duracion { get; set; }
        public string Nivel { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Matricula { get; set; }
        public decimal Precio { get; set; }
        public List<Alumno> AlumnosInscritos { get; set; }
        public List<(Alumno, string, int)> FormaPlanPago { get; set; }  // Alumno, Forma de Pago, Cuotas

        public Curso(string nombre, string contenido, int duracion, string nivel, DateTime fechaInicio, DateTime fechaFin, decimal matricula, decimal precio)
        {
            Nombre = nombre;
            Contenido = contenido;
            Duracion = duracion;
            Nivel = nivel;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Matricula = matricula;
            Precio = precio;
            AlumnosInscritos = new List<Alumno>();
            FormaPlanPago = new List<(Alumno, string, int)>();
        }

        public void InscribirAlumno(Alumno alumno, string formaPago, int cuotas)
        {
            AlumnosInscritos.Add(alumno);
            FormaPlanPago.Add((alumno, formaPago, cuotas));
        }

        public override string ToString()
        {
            string alumnos = string.Join(", ", AlumnosInscritos.Select(a => a.Nombre));
            string formaPlanPago = string.Join("; ", FormaPlanPago.Select(t => $"{t.Item1.Nombre}: {t.Item2}, {t.Item3} cuotas"));

            return $"Curso: {Nombre}, Nivel: {Nivel}, Duración: {Duracion} días, Precio: {Precio}, Alumnos: {alumnos}, Forma y Plan de Pago: {formaPlanPago}";
        }
    }
}

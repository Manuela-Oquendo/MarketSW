using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Hoteles
    {

        //Atributos clase Hoteles
        public String Direccion, Ciudad, Barrio, Telefono, Nombre;
        public Habitaciones[] habitaciones;

        public Hoteles(String NombreHo,String DireccionHo, String CiudadHo, String BarrioHo, String TelefonoHo, 
               Habitaciones[] habitacionesHo)
        {
            Nombre = NombreHo;
            Direccion = DireccionHo;
            Ciudad = CiudadHo;
            Barrio = BarrioHo;
            Telefono = TelefonoHo;
            habitaciones = habitacionesHo;
        }


        //Método para mostrar los hoteles cuando se entén registrando
        public override String ToString() 
        {
            String mensaje;
            mensaje = "\nNombre Hotel: " +Nombre+ "\nDirección: " + Direccion + "\nCiudad: " + Ciudad + "\nBarrio:" + Barrio + "\nTeléfono: " + Telefono;
            return mensaje;       
        }
    }
}

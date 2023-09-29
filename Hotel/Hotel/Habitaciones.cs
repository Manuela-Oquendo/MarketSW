using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    //Clase en la que se hara el registro y administracion de las habitaciones
    public class Habitaciones
    {
        //Atributos de cada habitacion
        private String Tipo, Telefono, Numero;
        private bool BanoPrivado, Calefaccion;

        public Habitaciones(String TipoHa, String TelefonoHa, String NumeroHa, bool BanoPrivadoHa, bool CalefaccionHa) 
        {
            Tipo = TipoHa;
            Telefono = TelefonoHa;
            Numero = NumeroHa;
            BanoPrivado = BanoPrivadoHa;
            Calefaccion = CalefaccionHa;
        }

        public override string ToString()
        {
            String mensaje;
            mensaje = "\nTipo de habitación: " + Tipo + "\nTeléfono de la habitación:" + Telefono +
                      "\nNúmero de la habitación: " + Numero + "\nBaño Privado: " + BanoPrivado + "\nCalefacción: " + Calefaccion;
            return mensaje;
        }
    }
}

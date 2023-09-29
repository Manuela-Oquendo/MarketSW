using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Registro
    {
        //Atributos de la clase Registro
        public String NombreHuesped, DireccionHuesped, ProfesionHuesped, EstadoCivilHuesped, 
                      HoraLevantar, FechaEntrada, FechaSalida, Desayuno, Bebida;
        public Hoteles hotel;
        public Habitaciones Habitacion;

        public Registro(String NombreHuespedRe, String DireccionHuespedRe, String ProfesionHuespedRe,String EstadoCivilHuespedRe,
                        String HoraLevantarRe, String FechaEntradaRe, String FechaSalidaRe, String DesayunoRe,
                        String BebidaRe, Hoteles hotelRe, Habitaciones HabitacionRe) 
        {
            NombreHuesped = NombreHuespedRe;
            DireccionHuesped = DireccionHuespedRe;
            ProfesionHuesped = ProfesionHuespedRe;
            EstadoCivilHuesped = EstadoCivilHuespedRe;
            HoraLevantar = HoraLevantarRe;
            FechaEntrada = FechaEntradaRe;
            FechaSalida = FechaSalidaRe;
            Desayuno = DesayunoRe;
            Bebida = BebidaRe;
            hotel = hotelRe;
            Habitacion = HabitacionRe;
        }


        //ToString de Registros, para mostrar un resumen de los registros

        public override string ToString()
        {
            String mensaje;
            mensaje = "\nNombre de huesped: " + NombreHuesped + "\nDirección: " + DireccionHuesped +
                      "\nProfesión: " + ProfesionHuesped + "\nEstado Civil: " + EstadoCivilHuesped +
                      "\nHora a despertar: " + HoraLevantar + "\nFecha de entrada: " + FechaEntrada +
                      "\nFecha de salida: " + FechaSalida + "\nDesayuno: " + Desayuno + "\nBebida: " + Bebida +
                      "\nInformación del Hotel:  \n" +
                      hotel.ToString() +
                      "\nInformación de la habitación: \n " +
                      Habitacion.ToString();
            return mensaje;            
        }
    }
}   

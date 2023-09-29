using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAgrario
{
    public class CuentaBancaria
    {
        //Atributos de la clase  (modificadores de accesso, tipo de dato, nombre)

        private String Nombre, Apellido, Direccion, NIT;
        private double Saldo;


        //Metodo constructor, los atributos del metodo constructor deben tener un alias, se mandan por parámetro
        public CuentaBancaria(String NombrePa, String ApellidoPa, String DireccionPa, String NITPa, double SaldoPa) 
        {
            //esto es lo mismo que el this. Deben estar dentro de los parametros y debe ser del mismo tipo.
            Nombre = NombrePa;
            Apellido = ApellidoPa;
            Direccion = DireccionPa;    
            NIT = NITPa;  
            Saldo = SaldoPa;    

        }


        //Metodos

        //Metodo Deposito, recibe una suma de dinero desde el exterior y lo agregara al campo saldo

        public double Deposito(double montoPa)
        {

            Saldo += montoPa;
            return Saldo;

        }

        /* Metodo Retiro: se encarga de realizar el retiro de una suma de dinero dada desde el exterior, se verifica que 
        se pueda realizar el retiro */

        public double Retiro(double montoPa)
        {
            if (Saldo > montoPa)
            {
                //Si s ecumple que el dinero que tengo es mayor o igual a lo que deseo retirar, entonces se hace el retiro
                Console.WriteLine("Retiro Exitoso");
                Saldo -= montoPa;

            } else
            {
                Console.WriteLine("No tiene saldo suficiente para realizar el retiro.");
                Console.WriteLine("Su saldo actual es: " + Saldo);

            }
            

            return Saldo;
        }


        //Metodo ConsultaSaldo: se encarga de mostrarnos el dinero que tenemos en la cuenta

        public void ConsultaSaldo()
        {
            Console.WriteLine("Su saldo actual es: " + Saldo);
        }


        /*Metodo ToString: se encarga de mostrarnos toda la informacion de la cuenta, el metodo ToString ya existe, 
         * mostrar datos en forma de cadena lo tiene C# implementado, entonces al que ya existe se le hace una sobrecarga.
        Para eso la instruccion OVERRIDE, para invalidar la accion predeterminada que tiene y que no me muestre las cosas
        como quiera*/

        public override string ToString()
        {
            String mensaje;
            mensaje = "\nTitular: " + Nombre + " " + Apellido + "\nDirección: " + Direccion + "\nNIT: " + NIT +
                      "\nSaldo Actual: $" + Saldo;

            return mensaje;
            

        }

        

    }
}

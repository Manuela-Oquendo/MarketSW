using Hotel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)

    {

        //Se definen los Desayunos
        String[] Desayunos = new String[]
        {
            "Cafe con Leche",
            "Te acompañado de pan"
        };

        //Se definen las Bebidas
        String[] Bebidas = new String[]
        {
            "Gaseosa",
            "Agua Mineral con gas",
            "Agua Mineral sin gas"
        };


        //Se definen Las Habitaciones para Hotel 1
        Habitaciones[] habitacionesHotelLosRecuerdos = new Habitaciones[]
        {
            new Habitaciones("Simple","321456","101", false , false),
            new Habitaciones("Doble","098567","102", true , false),
            new Habitaciones("Suite","765890","103", true , true)
        };

        //Se definen las Habitaciones para Hotel 2
        Habitaciones[] habitacionesHotelParaísoOscuro = new Habitaciones[]
        {
            new Habitaciones("Simple","648294","201", false , false),
            new Habitaciones("Doble","021467","202", true , false),
            new Habitaciones("Suite","76482740","203", true , true)
        };

        //Se definen los Hoteles
        Hoteles[] hoteles = new Hoteles[]
        {
            new Hoteles("Los Recuerdos","Barranco 1 con cañada 2","Tangamandapio","Aranjuez","123456",habitacionesHotelLosRecuerdos),
            new Hoteles("ParaísoOscuro","Potrero 3 con volado 17","Jerusalén","Caldas","098765",habitacionesHotelParaísoOscuro),
        };

        //Se piden los datos al Huesped
        Console.WriteLine("Esta a punto de realizar una reserva, presione una tecla para continuar: ");
        Console.WriteLine("\nSeleccione el hotel en el que se desea hospedar: ");
        for (int i = 0; i < hoteles.Length; i++)
        {
                Hoteles hotel = hoteles[i];
                Console.WriteLine("Opcion " +i + " : " + hotel.ToString());
        }

        int PosicionHotelSeleccionado = Convert.ToInt32(Console.ReadLine());
        Hoteles hotelSeleccionado = hoteles[PosicionHotelSeleccionado];
        //Se muestran las habitaciones del hotel seleccionado

        Console.WriteLine("Seleccione la habitación que desea: ");

        for (int i = 0; i < hotelSeleccionado.habitaciones.Length; i++)
        {
            Habitaciones habitacion = hotelSeleccionado.habitaciones[i];
            Console.WriteLine("Opcion " + i + " : " + habitacion.ToString());
        }

        int PosicionHabitacionSeleccionada = Convert.ToInt32(Console.ReadLine());
        Habitaciones habitacionSeleccionada = hotelSeleccionado.habitaciones[PosicionHabitacionSeleccionada];


        //Se piden los datos al huesped

        String NombreHuesped, DireccionHuesped, ProfesionHuesped, EstadoCivilHuesped,
               HoraLevantar, FechaEntrada, FechaSalida;

        Console.WriteLine("Ingrese los siguientes datos para completar el registro: ");
        Console.Write("\nNombre: ");
        NombreHuesped = Console.ReadLine();
        Console.Write("\nDirección: ");
        DireccionHuesped = Console.ReadLine();
        Console.Write("\nProfesión: " );
        ProfesionHuesped= Console.ReadLine();
        Console.Write("\nEstado Civil: ");
        EstadoCivilHuesped = Console.ReadLine();
        Console.Write("\nHoraLevantar: ");
        HoraLevantar = Console.ReadLine();
        Console.Write("\nFechaEntrada: ");
        FechaEntrada = Console.ReadLine();
        Console.Write("\nFechaSalida: ");
        FechaSalida = Console.ReadLine();


        //Se solicitan que el Huesped ingrese el desayuno que desea

        Console.WriteLine("Seleccione la opcion de desayuno que desea: ");

        for (int i = 0; i < Desayunos.Length; i++)
        {
            Console.WriteLine("Opcion " + i + " es: " + Desayunos[i]);
        }

        int posicionDesayunoSeleccionado = Convert.ToInt32(Console.ReadLine());
        String desayunoSeleccionado = Desayunos[posicionDesayunoSeleccionado];

        //Se solicitan que el Huesped ingrese la bebida que desea

        Console.WriteLine("Seleccione la opcion de bebida que desea: ");

        for (int i = 0; i < Bebidas.Length; i++)
        {
            Console.WriteLine("Opcion " + i + " es: " + Bebidas[i]);
        }

        int posicionBebidaSeleccionado = Convert.ToInt32(Console.ReadLine());
        String bebidaSeleccionado = Bebidas[posicionBebidaSeleccionado];

        Registro registro = new Registro(NombreHuesped, DireccionHuesped, ProfesionHuesped, EstadoCivilHuesped,
                                         HoraLevantar, FechaEntrada, FechaSalida,desayunoSeleccionado,bebidaSeleccionado, 
                                         hotelSeleccionado, habitacionSeleccionada );

        Console.WriteLine(registro.ToString());




    }
}
using BancoAgrario;

class Program
{

    //Metodo Main que se va a encargar de pedir los datos
    static void Main(String[] args)
    {
        //variables solo para el program
        double MontoAr, SaldoInicialAr; //MontoAr es para abrir la cuenta con algo de dinero
        String NombreAr, ApellidosAr, DireccionAr,NITAr; 
        int option; //Para que el usuario escoja la opcion que desea despues de crear la cuenta


        //Creación de la cuenta de Banco
        Console.Write("Estas a punto de crear una cuenta bancaria, presiona una tecla para continuar");
        Console.ReadKey(); //no entendi para que era :v

        Console.WriteLine("\nPor favor ingrese los datos que se piden a continuación: ");

        Console.Write("\nNombre: ");
        NombreAr = Console.ReadLine(); //Cuando la pregunta es de tipo string y la variable tambien,
                                       //solo se pone Console.ReadLine

        Console.Write("\nApellidos: ");
        ApellidosAr = Console.ReadLine();

        Console.Write("\nIdentificación: ");
        NITAr = Console.ReadLine();

        Console.Write("\nDirección: ");
        DireccionAr = Console.ReadLine();

        Console.Write("Deposite un monto inicial para abrir su cuenta: $ ");
        SaldoInicialAr = Convert.ToDouble(Console.ReadLine());
        //Cuando el mensaje es tipo String y la variable no, hay que hacerle una conversion a la variable.


        //Instancia de clase CuentaBancaria para poder enviarle los datos

        CuentaBancaria cliente = new CuentaBancaria(NombreAr, ApellidosAr, DireccionAr, NITAr, SaldoInicialAr);

        //Mensaje que se mostrara despues de la creacion de la cuenta
        Console.Write("¡Felicidades!, haz creado una nueva cuenta, presiona una tecla para continuar: ");
        Console.ReadKey();

        //Menú con las opciones de los metodos

        do
        {
            Console.WriteLine("\n1. Deposito");
            Console.WriteLine("2. Retiro");
            Console.WriteLine("3. Consulta Saldo");
            Console.WriteLine("4. Informacion de la cuenta");
            Console.WriteLine("5. Salir");

            Console.Write("\nIngrese una opcion que desea: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nIngrese el monto a depositar: $");
                    MontoAr = Convert.ToDouble(Console.ReadLine());
                    cliente.Deposito(MontoAr);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el valor que desea retirar: $");
                    MontoAr = Convert.ToDouble(Console.ReadLine());
                    cliente.Retiro(MontoAr);
                    break;
                case 3:
                    cliente.ConsultaSaldo();
                    break;
                case 4:
                    Console.WriteLine(cliente.ToString()); //El metodo ToString responde a un mensaje, se debe mostrar por mensaje
                    break;

            }


        } while (option >= 1 && option <= 4);
    }


}
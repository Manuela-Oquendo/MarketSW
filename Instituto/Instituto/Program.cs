using Instituto;

namespace PracticaPoo;
class Program
{
    public static Curso cursoIn;
    public static Curso cursoFr;
    public static Curso cursoPo;

    public static void Main(string[] args)
    {
        try


        {
            case "1":
                Console.WriteLine("\nCual curso desea consultar?: \n1. Inglés \n2. Francés \n3. Portugués ");
                int opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    Console.WriteLine(cursoIn);
                }
                else if (opc == 2)
                {
                    Console.WriteLine(cursoFr);
                }
                else if (opc == 3)
                {

                    Console.WriteLine(cursoPo);
                }
                else
                {
                    Console.WriteLine("\n\nCurso no válido, reintente");

                }
                break;

            case "2":
                Console.WriteLine("\nInscripción de un nuevo alumno al curso:");
                Console.Write("Ingrese el curso a matricular: \n1.Ingles 2.Frances 3.Portugués:\n");
                int curse = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nombre del alumno: ");
                string nombreNuevoAlumno = Console.ReadLine();
                Console.Write("Ingrese el apellido del alumno: ");
                string apellidoNuevoAlumno = Console.ReadLine();
                Console.Write("Ingrese la cédula del alumno: ");
                string cedulaNuevoAlumno = Console.ReadLine();
                Console.Write("Ingrese la dirección del alumno: ");
                string direccionNuevoAlumno = Console.ReadLine();
                Console.Write("Ingrese el teléfono del alumno: ");
                string telefonoNuevoAlumno = Console.ReadLine();
                Console.Write("Ingrese la ocupación del alumno: ");
                string ocupacionNuevoAlumno = Console.ReadLine();
                Console.Write("Ingrese la forma de pago: ");
                string formapago = Console.ReadLine();
                Console.Write("Ingrese la cantidad de cuotas: 1,2 ó 3 ");
                int cuotas = int.Parse(Console.ReadLine());


                if (curse == 1)
                {
                    Alumno nuevoAlumno = new Alumno(cedulaNuevoAlumno, apellidoNuevoAlumno, nombreNuevoAlumno, direccionNuevoAlumno, telefonoNuevoAlumno, ocupacionNuevoAlumno);
                    cursoIn.InscribirAlumno(nuevoAlumno, formapago, cuotas);
                    Console.WriteLine("Alumno inscrito en el curso de Inglés.");
                }
                else if (curse == 2)
                {

                    Alumno nuevoAlumno = new Alumno(cedulaNuevoAlumno, apellidoNuevoAlumno, nombreNuevoAlumno, direccionNuevoAlumno, telefonoNuevoAlumno, ocupacionNuevoAlumno);
                    cursoFr.InscribirAlumno(nuevoAlumno, formapago, cuotas);
                    Console.WriteLine("Alumno inscrito en el curso de Frances.");

                }
                else if (curse == 3)
                {

                    Alumno nuevoAlumno = new Alumno(cedulaNuevoAlumno, apellidoNuevoAlumno, nombreNuevoAlumno, direccionNuevoAlumno, telefonoNuevoAlumno, ocupacionNuevoAlumno);
                    cursoFr.InscribirAlumno(nuevoAlumno, formapago, cuotas);
                    Console.WriteLine("Alumno inscrito en el curso de Portugués.");

                }
                else
                {
                    Console.WriteLine("Curso no válido, reintente");

                }

                break;

            case "3":
                return;

            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
            }

            Console.WriteLine();

        } catch {
            Console.WriteLine("Error, opción incorrecta.");

        }
    }
}
    

        




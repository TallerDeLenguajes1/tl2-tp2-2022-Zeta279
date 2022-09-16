using NLog;
using TP2Taller2.Clases;

namespace TP2Taller2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Logger = LogManager.GetCurrentClassLogger();
            int cantidad;
            List<Alumno> alumnos = new List<Alumno>();
            int id, dni, curso;
            string nombre, apellido;

            Console.WriteLine("Ingresar cantidad de alumnos:");
            cantidad = Control.IngresarNumPositivo();

            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingresar ID:");
                id = Control.IngresarNumPositivo();
                Console.WriteLine("Ingresar nombre:");
                nombre = Control.IngresarString();
                Console.WriteLine("Ingresar apellido:");
                apellido = Control.IngresarString();
                Console.WriteLine("Ingresar DNI:");
                dni = Control.IngresarNumPositivo();
                Console.WriteLine("Ingresar curso (0: Atletismo, 1: Voley, 2: Futbol):");
                curso = Control.IngresarNumPositivo();
                while (curso > 2)
                {
                    Console.WriteLine("Ingrese una opción valida (0: Atletismo, 1: Voley, 2: Futbol):");
                    curso = Control.IngresarNumPositivo();
                }
                alumnos.Add(new Alumno(id, nombre, apellido, dni, curso));
                Logger.Info("Alumno añadido");

                HelperDeArchivos.EscribirCSV(alumnos[i]);
                Logger.Debug("CSV escrito");
            }
        }
    }
}
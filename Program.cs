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

            Console.WriteLine("Ingresar cantidad de alumnos:");
            cantidad = Control.IngresarNumPositivo();
        }
    }
}
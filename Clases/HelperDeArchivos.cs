namespace TP2Taller2.Clases
{
    class HelperDeArchivos
    {
        static public void EscribirCSV(Alumno alumno)
        {
            string[] deportes = { "Atletismo", "Voley", "Futbol" };

            foreach(var s in deportes)
            {
                if (!File.Exists(s + ".csv"))
                {
                    File.Create(s + ".csv").Close();
                    File.WriteAllText(s + ".csv", "ID;DNI;Nombre;Apellido\n");
                }
            }

            File.AppendAllText(deportes[alumno.Curso] + ".csv" , alumno.ToCSV());
        }

        static public void LimpiarCSV(string path)
        {
            if (Path.GetFileName(path).Split('.')[1] == "csv") File.Delete(path);
        }
    }
}

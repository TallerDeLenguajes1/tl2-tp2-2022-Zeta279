namespace TP2Taller2.Clases
{
    class Alumno
    {
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private int Dni { get; set; }
        public int Curso { get; set; }

        public Alumno(int id, string nombre, string apellido, int dni, int curso)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Curso = curso;
        }

        public string ToCSV()
        {
            return $"{Id};{Nombre};{Apellido};{Dni}\n";
        }

        public override string ToString()
        {
            string[] deportes = { "Atletismo", "Voley", "Futbol" };
            return $"DNI: {Dni}\nNombre completo: {Nombre} {Apellido}\nCursa: {deportes[Curso]}";
        }
    }
}

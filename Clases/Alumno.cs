namespace LogTest.Clases
{
    class Alumno
    {
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private int Dni { get; set; }
        public int Curso { get; set; }

        public string ToCSV()
        {
            return $"{Id};{Nombre};{Apellido};{Dni}";
        }

        public override string ToString()
        {
            string[] deportes = { "Atletismo", "Voley", "Futbol" };
            return $"DNI: {Dni}\nNombre completo: {Nombre} {Apellido}\nCursa: {deportes[Curso]}";
        }
    }
}

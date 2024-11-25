namespace AlumnosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno mora = new Alumno();
            mora.Nombre = "Santiago Mora";
            mora.Grupo = "DGDIE11";
            mora.Contrasena = "abc123";

            Console.WriteLine(mora.Contrasena);
        }
    }
}

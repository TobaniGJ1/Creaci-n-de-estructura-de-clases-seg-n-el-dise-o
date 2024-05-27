using OOPMiembrosComunidad.Class;

internal class Program
{
    private static void Main(string[] args)
    {
        IMiembros empleado = new Empleado();
        empleado.Greeting();

        IMiembros estudiante = new Estudiantes();
        estudiante.Greeting();

        IMiembros exalumnos = new ExAlumno();
        exalumnos.Greeting();

        Console.ReadKey();
    }
}
namespace EjerciciosNet.Ejercicio02_AdminCurso;

public class Curso
{
    public string NombreCurso {get; set;}
    public int Cupo {get; set;}

    public List<Estudiante> Inscriptos {get; set;}= new List<Estudiante>();

}

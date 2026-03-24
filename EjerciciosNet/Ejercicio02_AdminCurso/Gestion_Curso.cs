using EjerciciosNet.Ejercicio02_AdminCurso;

namespace EjerciciosNet.Ejercicio02_AdminCurso;

public class Gestion_Curso
{
    // public List<Curso> Cursos {get; set;} = new List<Curso>();
    public bool InscribirEstudiante(Curso curso, Estudiante estudiante)
    {
        if (curso.Inscriptos.Count < curso.Cupo)
        {
            curso.Inscriptos.Add(estudiante);
            return true;
        }
        return false; 
    }
    public bool DarBajaCurso(Curso curso, Estudiante estudiante)
    {
        return curso.Inscriptos.Remove(estudiante);
    }
    public bool ConsultaCupo(Curso curso)
    {
        if (curso.Inscriptos.Count < curso.Cupo)
        {
            return true;
        } else
        {
            return false;
        }
    }

}

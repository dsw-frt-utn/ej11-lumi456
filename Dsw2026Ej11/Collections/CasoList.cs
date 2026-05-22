using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    //Crear un campo que represente una lista de alumnos (List<>)
    private readonly List<Alumno> alumnos = [];

    //Incluir un método para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }
    //Incluir un método para retornar la lista
    public List<Alumno> ObtenerAlumnos()
    {
        return alumnos;
    }
    //Incluir un método para buscar un alumno por nombre
    public Alumno? BuscarPorNombre(string nombre)
    {
        return alumnos.Find(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }
    //Incluir un método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }
    //Incluir un método para eliminar un alumno en una determinada posición de la lista
    public void EliminarAlumnoEnPosicion(int posicion)
    {
        if(posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
        }
    }
}

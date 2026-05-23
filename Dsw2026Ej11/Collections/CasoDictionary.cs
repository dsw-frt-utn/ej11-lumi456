using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoDictionary
{
    //Crear un diccionario donde la clave sea el legajo y el valor el alumno
    private readonly Dictionary<int, Alumno> alumnos = [];

    //Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno.Id, alumno);
    }

    //Incluir un método para buscar un alumno utilizando la clave
    public Alumno? BuscarPorClave(int legajo)
    {
        alumnos.TryGetValue(legajo, out Alumno? alumno);
        return alumno;  
    }

    //Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return alumnos;
    }

    //Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarPorClave(int legajo)
    {
        alumnos.Remove(legajo);
    }
}
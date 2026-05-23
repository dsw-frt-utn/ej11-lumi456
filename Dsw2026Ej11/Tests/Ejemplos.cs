using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new();

        //Agregar 3 alumnos a la lista
        casoList.AgregarAlumno(new Alumno(1, "Juan", 7.0));
        casoList.AgregarAlumno(new Alumno(2, "Maria", 8.0));
        casoList.AgregarAlumno(new Alumno(3, "Luca", 5.5));

        //Listar por consola los alumnos
        Console.WriteLine("-------- Lista inicial de Alumnos --------");
        foreach(var alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("\n--- Buscando a Luca ---");
        Alumno? alumnoEncontrado = casoList.BuscarPorNombre("Luca");
        if(alumnoEncontrado is not null)
        {
            Console.WriteLine($"Encontrado: {alumnoEncontrado}");
        }

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("\n--- Buscando a Francisco ----");
        Alumno? alumnoNoExiste = casoList.BuscarPorNombre("Francisco");
        if( alumnoNoExiste is null)
        {
            Console.WriteLine("No existe");
        }

        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("\n--- Eliminando a Maria ---");
        Alumno? alumnoEliminar = casoList.BuscarPorNombre("Maria");
        if(alumnoEliminar != null)
        {
            casoList.EliminarAlumno(alumnoEliminar);
        }
        foreach(var alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("\n--- Eliminado el primer elemento de la lista ---");
        casoList.EliminarAlumnoEnPosicion(0);
        
        foreach(var alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new();

        //Agregar 3 alumnos al diccionario
        casoDictionary.AgregarAlumno(new Alumno(58012, "Abigail", 7.5));
        casoDictionary.AgregarAlumno(new Alumno(58612, "Carlos", 6.5));
        casoDictionary.AgregarAlumno(new Alumno(60123, "Nila", 8));

        //Listar por consola los alumnos
        Console.WriteLine("-------- Lista de Alumnos en el Diccionario --------");
        foreach(KeyValuePair<int, Alumno> entrada in casoDictionary.ObtenerDiccionario())
        {
            Console.WriteLine($"Clave [{entrada.Key}]: {entrada.Value}");
        }

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("\n--- Buscar legajo: 58612 ---");
        Alumno? alumnoEncontrado = casoDictionary.BuscarPorClave(58612);
        if( alumnoEncontrado is not null)
        {
            Console.WriteLine($"Encontrado: {alumnoEncontrado}");
        }

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("\n--- Buscar legajo: 60105 ---");
        Alumno? alumnoNoExiste = casoDictionary.BuscarPorClave(60105);
        if (alumnoNoExiste is null)
        {
            Console.WriteLine("No existe");
        }

        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("\n--- Eliminar legajo: 60123 ---");
        casoDictionary.EliminarPorClave(60123);
        foreach(var alumno in casoDictionary.ObtenerDiccionario().Values)
        {
            Console.WriteLine(alumno);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var casoLinq = new CasoLinq();

        Console.WriteLine("-------- Resultados de consultas LINQ --------");
        Console.WriteLine($"Primero: {casoLinq.GetPrimero().Titulo}");
        Console.WriteLine($"Ultimo: {casoLinq.GetUltimo().Titulo}");
        Console.WriteLine($"Suma total de precios: {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio de Precios: {casoLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\n--- Libros con ID > 15 ---");
        foreach (var libro in casoLinq.GetListById())
        {
            Console.WriteLine($"ID: {libro.Id} - {libro.Titulo}");
        }

        Console.WriteLine("\n--- Lista de Titulos y Precios ---");
        foreach(var libro in casoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }
        
        var libroMasCaro = casoLinq.GetMayorPrecio();
        Console.WriteLine($"\nLibro mas caro: {libroMasCaro.Titulo} ({libroMasCaro.Precio:C})");

        var libroMasBarato = casoLinq.GetMenorPrecio();
        Console.WriteLine($"\nLibro mas barato: {libroMasBarato.Titulo} ({libroMasBarato.Precio:C})");

        Console.WriteLine("\n--- Libro con precio mayor al promedio ---");
        foreach (var libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"{libro.Titulo}: {libro.Precio:C}");
        }

        Console.WriteLine("\n--- Libros ordenados por titulo descendiente ----");
        foreach (var libro in casoLinq.GetOrdenados())
        {
            Console.WriteLine(libro.Titulo);
        }
    }
}

using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoLinq
{
    private readonly List<Libro> libros = Libro.CrearLista();

    //1. Obtener el primer libro(GetPrimero)
    public Libro GetPrimero() => libros.First();

    //2. Obtener el último libro(GetUltimo)
    public Libro GetUltimo() => libros.Last();

    //3. Obtener la suma de precios(GetTotalPrecios)
    public decimal GetTotalPrecios() => libros.Sum(l => l.Precio);

    //4.Obtener el promedio de precios(GetPromedioPrecios)
    public decimal GetPromedioPrecios() => libros.Average(l => l.Precio);

    //5. Obtener la lista de libros con Id mayor a 15 (GetListById)
    public IEnumerable<Libro> GetListById() => libros.Where(l => l.Id > 15);

    //6. Obtener una lista de cada libro con su título y precio en formato moneda(GetLibros) (debe retornar una lista de string)
    public IEnumerable<string> GetLibros() => libros.Select(l => $"{l.Titulo} - {l.Precio:C}");

    //7. Obtener el libro con el precio más alto(GetMayorPrecio)
    public Libro GetMayorPrecio() => libros.OrderBy(l => l.Precio).Last();

    //8. Obtener el libro con el precio más bajo(GetMenorPrecio)
    public Libro GetMenorPrecio() => libros.OrderBy(l => l.Precio).First();

    //9. Obtener los libros cuyo precio sea mayor al promedio(GetMayorPromedio)
    public IEnumerable<Libro> GetMayorPromedio()
    {
        decimal promedio = GetPromedioPrecios();
        return libros.Where(l => l.Precio > promedio);
    }

    //10.Obtener los libros ordenados por título de forma descendente
    public IEnumerable<Libro> GetOrdenados() => libros.OrderByDescending(l => l.Titulo);
}
LinqQueries queries=new LinqQueries();

//todos los libros
Console.WriteLine("Todos los libros");
PrintValues(queries.TodaLaColeccion());
Console.WriteLine("____________________________________________________________");
//libros después del 2000
Console.WriteLine("Libros despues del 20000");
PrintValues(queries.LibrosDespuesDel2000());
Console.WriteLine("____________________________________________________________");
//kibros qye contiene action y mas de 250 paginas
Console.WriteLine("Libros con mas de 250 y con la palabra action");
PrintValues(queries.LibrosConMasDe250());
Console.WriteLine("____________________________________________________________");
//Verificando si los libros tiene status
Console.WriteLine($"Todos los libros tienen status: {queries.VerificarSiTieneStatus()}");
Console.WriteLine("____________________________________________________________");
//verificar si alguno se publico en 2005
Console.WriteLine($"Algun libro fue publicado en 2005: {queries.VerificarSiAlgunoMayorA2005()}");
void PrintValues(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1,15} {2,9}\n", "Titulo", "N. de paginas", "Fecha publicación");
    foreach (var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1,15} {2,9}\n", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

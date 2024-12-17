public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();
    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("C:\\Users\\User\\Documents\\C#\\LINQ\\LINQ\\books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }
    public IEnumerable<Book> LibrosDespuesDel2000()
    {
        //extensioon metod
        //return librosCollection.Where(book => book.PublishedDate.Year > 2000);

        //queries expression
        return from libro in librosCollection where libro.PublishedDate.Year > 2000 && libro.PageCount > 0 select libro;

    }
    public IEnumerable<Book> LibrosConMasDe250()
    {
        return from libro in librosCollection where libro.PageCount > 250 && libro.Title.ToLower().Contains("action") select libro;
    }
    public bool VerificarSiTieneStatus() {
        return librosCollection.All(libro => libro.Status != string.Empty);

    }
    public bool VerificarSiAlgunoMayorA2005()
    {
        return librosCollection.Any(libro => libro.PublishedDate.Year == 2005);
    }
    public IEnumerable<Book> LibrosOrdenasAsc()
    {
        return librosCollection.Where(libro => libro.Categories.Contains("Java")).OrderBy(libro => libro.Title);
    }
    public IEnumerable<Book> LibrosOrdenasDesc()
    {
        return librosCollection.Where(libro => libro.PageCount > 450).OrderByDescending(libro => libro.PageCount);
    }
    public IEnumerable<Book> TresPrimerosLibrosJavaOrdenadosPorFecha()
    {
        return librosCollection
            .Where(libro => libro.Categories.Contains("Java"))
            .OrderBy(libro => libro.PublishedDate)
            .TakeLast(3);
    }
    public IEnumerable<Book> TercerYCuartoLibro()
    {
        return librosCollection
            .Where(libro=>libro.PageCount>400)
            .Take(4)
            .Skip(2);
    }

    //solo sleccionamos ciertas propiedades
    public IEnumerable<Book> tresPrimerosLibros()
    {
        return librosCollection.Take(3).Select(libro =>new Book() { Title = libro.Title, PageCount = libro.PageCount });
    }
    public int CantidadDeLibrosEntre200y500()
    {
        return librosCollection.Count(libro => libro.PageCount >= 200 && libro.PageCount <= 500);
    }
    public DateTime FechaDePublicacionMasReciente()
    {
        return librosCollection.Min(libros => libros.PublishedDate);
    }
    public int LibroConMasPAg()
    {
        return librosCollection.Max(libro => libro.PageCount);
    }
    public Book LibroConMenorNumDePaginas()
    {
        return librosCollection.MinBy(libro => libro.PageCount > 0);
    }
    public Book LibroMasReciente()
    {
        return librosCollection.MaxBy(libro => libro.PublishedDate);
    }
    public int SumaDeLosLibrosEntre200y500()
    {
        return librosCollection.Where(libro=>libro.PageCount>=200 &&libro.PageCount<=500).Sum(libro=> libro.PageCount);
    }
    public string LibrosDespuesDel2016()
    {
        return librosCollection
            .Where(libro => libro.PublishedDate.Year >= 2015)
            .Aggregate("", (TitulosLibros, next) =>
            {
                if (TitulosLibros != string.Empty)
                {
                    return TitulosLibros += " - " + next.Title;
                }
                else {
                    return TitulosLibros += next.Title;
                }
            });
    }
    public double PromedioDeLetrasEnTitulos()
    {
        return librosCollection.Average(libro => libro.Title.Length);
    }
    public IEnumerable<IGrouping<int,Book>> ListaDespuesdel200()
    {
        return librosCollection.Where(libros => libros.PublishedDate.Year >= 2000).GroupBy(libro => libro.PublishedDate.Year);
    }
    public ILookup<char, Book> DiccionarioDeLibrosPorLetra()
    {
        return librosCollection.ToLookup(libro => libro.Title[0], libro=> libro);
    }
    public IEnumerable<Book> JoinEntreDosCondicionales()
    {
        var librosMayor2005 = librosCollection.Where(libro => libro.PublishedDate.Year > 2005);
        var librosCon400pag = librosCollection.Where(libro => libro.PageCount > 500);
        return librosMayor2005.Join(librosCon400pag,libro_01=>libro_01.Title,libro_02=>libro_02.Title,(libro_01,libro_02)=>libro_01);
    }
}
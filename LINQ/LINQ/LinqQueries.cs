
    public class LinqQueries
    {
        private List<Book> librosCollection = new List<Book>();
        public LinqQueries()
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\User\\Documents\\C#\\LINQ\\LINQ\\books.json"))
            {
                string json = reader.ReadToEnd();
                this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true});
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
            return from libro in librosCollection where libro.PublishedDate.Year > 2000 && libro.PageCount>0 select libro;

        }
        public IEnumerable<Book> LibrosConMasDe250()
    {
        return from libro in librosCollection where libro.PageCount > 250 && libro.Title.ToLower().Contains("action") select libro;
    }
        public bool VerificarSiTieneStatus(){
        return librosCollection.All(libro=>libro.Status != string.Empty);

    }
        public bool VerificarSiAlgunoMayorA2005()
    {
        return librosCollection.Any(libro => libro.PublishedDate.Year == 2005);
    }
    }
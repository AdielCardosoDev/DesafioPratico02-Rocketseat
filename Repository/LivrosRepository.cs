namespace DesafioPratico02_Rocketseat.Repository
{
    public class LivrosRepository
    {
        private static List<Livro> livros = new List<Livro>();
        private static int nextId = 1;

        public static List<Livro> GetAll() => livros;

        public static Livro GetById(int id) => livros.FirstOrDefault(p => p.Id == id);

        public static void Add(Livro livro)
        {
            livro.Id = nextId++;
            livros.Add(livro);
        }

        public static void Update(Livro livro)
        {
            var index = livros.FindIndex(p => p.Id == livro.Id);
            if (index != -1)
                livros[index] = livro;
        }

        public static void Delete(int id)
        {
            var livro = GetById(id);
            if (livro != null)
                livros.Remove(livro);
        }
    }
}

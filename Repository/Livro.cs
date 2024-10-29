namespace DesafioPratico02_Rocketseat.Repository
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public Genero Genero { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }

    public enum Genero
    {
        Ficcao,
        romance,
        misterio
    }
}

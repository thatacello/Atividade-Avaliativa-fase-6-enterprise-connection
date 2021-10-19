namespace Atividade_Avaliativa_fase_6_front.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Avaliacoes { get; set; }
        public string Descricao { get; set; }
        public string Comentario1 { get; set; }
        public string Comentario2 { get; set; }
        public Card(int id, string titulo, int avaliacoes, string descricao, string comentario1, string comentario2)
        {
            Id = id;
            Titulo = titulo;
            Avaliacoes = avaliacoes;
            Descricao = descricao;
            Comentario1 = comentario1;
            Comentario2 = comentario2;
        }
        public Card(int id, string titulo, int avaliacoes, string comentario1, string comentario2)
        {
            Id = id;
            Titulo = titulo;
            Avaliacoes = avaliacoes;
            Comentario1 = comentario1;
            Comentario2 = comentario2;
        }
        public Card(int id, string titulo, int avaliacoes, string descricao)
        {
            Id = id;
            Titulo = titulo;
            Avaliacoes = avaliacoes;
            Descricao = descricao;
        }
        public Card(int id, string titulo, string descricao)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
        }
        public Card()
        {
        }
    }
}
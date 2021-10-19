namespace Atividade_Avaliativa_fase_6_front.Models
{
    public class DicasUteis : Card
    {
        public string PublicadoPor { get; set; }
        public DicasUteis(int id, string titulo, string descricao, string publicadoPor)
            : base (id, titulo, descricao)
        {
            PublicadoPor = publicadoPor;
        }

    }
}
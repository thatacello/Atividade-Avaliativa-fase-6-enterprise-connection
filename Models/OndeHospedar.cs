namespace Atividade_Avaliativa_fase_6_front.Models
{
    public class OndeHospedar : Card
    {
        public string Servico1 { get; set; }
        public string Servico2 { get; set; }
        public string Servico3 { get; set; }

        public OndeHospedar(int id, string titulo, int avaliacoes, string descricao, string servico1, string servico2, string servico3) 
            : base (id, titulo, avaliacoes, descricao)
        {
            Servico1 = servico1;
            Servico2 = servico2;
            Servico3 = servico3;
        }
    }
}
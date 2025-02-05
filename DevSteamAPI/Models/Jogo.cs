namespace DevSteamAPI.Models
{
    public class Jogo
    {
        public Guid JogoId { get; set; }
        public string Nome { get; set; }
        public int classificacao { get; set; }
        public string? Descricao { get; set; }
        public string? imagem { get; set; }
        public Guid CategoriaId { get; set; }
        public Categoria? categoria { get; set; }
    }
}

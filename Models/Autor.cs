namespace DevBlo.Api.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public ICollection<Postagem>? Postagens { get; set; } = new List<Postagem>();
    }
}

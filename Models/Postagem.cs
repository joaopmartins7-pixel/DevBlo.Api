using System.Text.Json.Serialization;

namespace DevBlo.Api.Models
{
    public class Postagem
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataPublicacao { get; set; }

        public int AutorId { get; set; }

        [JsonIgnore]
        public Autor Autor { get; set; }

        public ICollection<Comentario>? Comentarios { get; set; }
    }
}

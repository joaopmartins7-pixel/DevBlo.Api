using System.Text.Json.Serialization;

namespace DevBlo.Api.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string NomeUsuario { get; set; }

        public int PostagemId { get; set; }

        [JsonIgnore]
        public Postagem? Postagem { get; set; }
    }
}

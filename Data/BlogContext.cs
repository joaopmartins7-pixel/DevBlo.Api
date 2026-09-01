using DevBlo.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DevBlo.Api.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}

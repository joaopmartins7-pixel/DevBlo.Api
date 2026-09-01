using DevBlo.Api.Data;
using DevBlo.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevBlo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentariosController : ControllerBase
    {
        private readonly BlogContext _context;

        public ComentariosController(BlogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async
            Task<ActionResult<IEnumerable<Comentario>>> GetComentarios()
        {
            return await _context.Comentarios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Comentario>> AddComentario(Comentario comentario)
        {
            _context.Comentarios.Add(comentario);
            await _context.SaveChangesAsync();
            return Ok(comentario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutor(int id, Comentario comentario)
        {
            if (id != comentario.Id)
            {
                return BadRequest();
            }

            _context.Entry(comentario).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok("Comentario salvo com sucesso!!!");
        }
    }
}

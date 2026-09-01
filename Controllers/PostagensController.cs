using DevBlo.Api.Data;
using DevBlo.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevBlo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostagensController : ControllerBase
    {
        private readonly BlogContext _context;

        public PostagensController(BlogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async
            Task<ActionResult<IEnumerable<Postagem>>> GetPostagens()
        {
            return await _context.Postagens.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Autor>> AddAutor(Postagem postagem)
        {
            _context.Postagens.Add(postagem);
            await _context.SaveChangesAsync();
            return Ok(postagem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostagem(int id, Postagem postagem)
        {
            if (id != postagem.Id)
            {
                return BadRequest();
            }

            _context.Entry(postagem).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok("Postagem salva com sucesso!!!");
        }
    }
}

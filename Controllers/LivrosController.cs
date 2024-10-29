using DesafioPratico02_Rocketseat.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DesafioPratico02_Rocketseat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var livros = LivrosRepository.GetAll();
            return Ok(livros);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var livro = LivrosRepository.GetById(id);
            return livro != null ? Ok(livro) : NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Livro livro)
        {
            LivrosRepository.Add(livro);
            return CreatedAtAction(nameof(Get), new { id = livro.Id }, livro);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Livro livro)
        {
            if (id != livro.Id) return BadRequest();

            var existingProduto = LivrosRepository.GetById(id);
            if (existingProduto == null) return NotFound();

            LivrosRepository.Update(livro);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var livro = LivrosRepository.GetById(id);
            if (livro == null) return NotFound();

            LivrosRepository.Delete(id);
            return NoContent();
        }
    }
}

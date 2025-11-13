using Microsoft.AspNetCore.Mvc;
using API_EduControl.Models;
using API_EduControl.Interfaces;
using API_EduControl.DTOs.Curso;

namespace API_EduControl.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : Controller
    {
        private readonly ICursoService _service;

        public CursoController(ICursoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CriarCurso(CriarCursoDTO curso)
        {
            if (curso == null)
                return BadRequest("Curso não informado!");

            var resultado = await _service.CriarCursoAsync(curso);
            return Ok(resultado);
        }

        [HttpGet]
        public async Task<List<Curso>> ListarCursos()
        {
            var cursos = await _service.ListarCursosAsync();
            return cursos;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Curso>> AtualizarCurso(int id, [FromBody] AtualizarCursoDTO curso)
        {
            if (curso == null)
                return BadRequest("Dados inválidos.");

            var atualizado = await _service.AtualizarCursoAsync(id, curso);

            if (atualizado == null)
                return NotFound($"Curso não encontrado com o id informado.");

            return Ok(atualizado);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarCurso(int id)
        {
            if (id == 0)
                return BadRequest("Id não informado");

            await _service.DeletarCursoAsync(id);
            return Ok("Curso removido com sucesso");
        }
    }
}

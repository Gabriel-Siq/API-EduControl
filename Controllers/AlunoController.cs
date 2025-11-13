using Microsoft.AspNetCore.Mvc;
using API_EduControl.Models;
using API_EduControl.Interfaces;
using API_EduControl.DTOs.Aluno;

namespace API_EduControl.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {
        private readonly IAlunoService _service;

        public AlunoController(IAlunoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CriarAluno(CriarAlunoDTO aluno)
        {
            if (aluno == null)
                return BadRequest("Aluno não informado!");

            var resultado = await _service.CriarAlunoAsync(aluno);
            return Ok(resultado);
        }

        [HttpGet]
        public async Task<List<Aluno>> ListarAlunos()
        {
            var alunos = await _service.ListarAlunosAsync();
            return alunos;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Aluno>> AtualizarAluno(int id, [FromBody] AtualizarAlunoDTO aluno)
        {
            if (aluno == null)
                return BadRequest("Dados inválidos.");

            var atualizado = await _service.AtualizarAlunoAsync(id, aluno);

            if (atualizado == null)
                return NotFound($"Aluno não encontrado com o id informado.");

            return Ok(atualizado);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarAluno(int id)
        {
            if (id == 0)
                return BadRequest("Id não informado");

            await _service.DeletarAlunoAsync(id);
            return Ok("Aluno removido com sucesso");
        }
    }
}

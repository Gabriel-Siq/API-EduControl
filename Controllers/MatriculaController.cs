using API_EduControl.DTOs.Matricula;
using API_EduControl.Interfaces;
using API_EduControl.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_EduControl.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatriculaController: Controller
    {
        private readonly IMatriculaService _service;

        public MatriculaController(IMatriculaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Matricula>> ListarMatriculas()
        {
            var matriculas = await _service.ListarMatriculasAsync();
            return matriculas;
        }

        [HttpPost]
        public async Task<IActionResult> CriarMatricula(CriarMatriculaDTO matricula)
        {
            if (matricula == null)
                return BadRequest("Matricula não informada!");

            var resultado = await _service.CriarMatriculaAsync(matricula);
            return Ok(resultado);
        }

        [HttpDelete("{alunoId:int}/{cursoId:int}")]
        public async Task<IActionResult> DeletarMatricula(int alunoId, int cursoId)
        {
            if (alunoId == 0 || cursoId == 0)
                return BadRequest("Os Id's não foram informados corretamente");

            await _service.DeletarMatriculaAsync(alunoId, cursoId);
            return Ok("Matricula removida com sucesso");
        }
    }
}

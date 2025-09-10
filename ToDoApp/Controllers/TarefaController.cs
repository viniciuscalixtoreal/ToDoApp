using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.DTO;
using ToDoApp.Application.Interfaces;
using ToDoApp.Application.Services;

namespace ToDoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _service;

        public TarefaController(ITarefaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Tarefas()
        {
            var tarefas = await _service.Tarefas();
            return Ok(tarefas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> TarefaPorId(int id)
        {
            var tarefa = await _service.TarefaById(id);

            if (tarefa is null)
                return NotFound("Tarefa não encontrada.");

            return Ok(tarefa);
        }

        [HttpPost]
        public async Task<IActionResult> CriarTarefa(TarefaDTO tarefaDTO)
        {
            var tarefaCriada = await _service.CriarTarefa(tarefaDTO);

            if (tarefaCriada is null)
                return BadRequest("Ocorreu um erro ao criar tarefa.");

            return Ok(tarefaCriada);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarTarefa(TarefaDTO tarefaDTO)
        {
            var tarefaAtualizada = await _service.AtualizarTarefa(tarefaDTO);

            if (tarefaAtualizada is null)
                return BadRequest("Ocorreu um erro ao atualizar tarefa.");

            return Ok(tarefaAtualizada);
        }

        [HttpDelete]
        public async Task<IActionResult> ExcluirTarefa(int id)
        {
            var tarefaExcluida = await _service.ExcluirTarefa(id);

            if (tarefaExcluida is null)
                return BadRequest("Ocorreu um erro ao excluir tarefa.");

            return Ok(tarefaExcluida);
        }
    }
}

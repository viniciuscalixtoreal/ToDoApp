using ToDoApp.Application.DTO;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Interfaces
{
    public interface ITarefaService
    {
        Task<IEnumerable<TarefaDTO>> Tarefas();
        Task<TarefaDTO> TarefaById(int id);
        Task<TarefaDTO> CriarTarefa(TarefaDTO tarefa);
        Task<TarefaDTO> AtualizarTarefa(TarefaDTO tarefa);
        Task<TarefaDTO> ExcluirTarefa(int id);
    }
}

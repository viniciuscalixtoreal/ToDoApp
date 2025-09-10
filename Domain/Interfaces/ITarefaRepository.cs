using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Abstraction
{
    public interface ITarefaRepository
    {
        Task<IEnumerable<Tarefa>> Tarefas();
        Task<Tarefa> TarefaById(int id);
        Task<Tarefa> CriarTarefa(Tarefa tarefa);
        Task<Tarefa> AtualizarTarefa(Tarefa tarefa);
        Task<Tarefa> ExcluirTarefa(int id); 
    }
}

using Microsoft.EntityFrameworkCore;
using ToDoApp.Domain.Abstraction;
using ToDoApp.Domain.Entities;
using ToDoApp.Infrastructure.Context;

namespace ToDoApp.Infrastructure.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly ApplicationDbContext _context;

        public TarefaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tarefa>> Tarefas()
        {
            return await _context.Tarefas.ToListAsync();
        }

        public async Task<Tarefa> TarefaById(int id)
        {
            var tarefa = await _context.Tarefas.FirstOrDefaultAsync(x => x.Id == id);

            if (tarefa == null)
                throw new InvalidOperationException("Tarefa não encodntrada.");

            return tarefa;
        }

        public async Task<Tarefa> CriarTarefa(Tarefa tarefa)
        {
            if (tarefa == null)
                throw new ArgumentNullException(nameof(tarefa));

            tarefa.DataCriacao = DateTime.Now;
            _context.Tarefas.Add(tarefa);
            await _context.SaveChangesAsync();
            return tarefa;
        }

        public async Task<Tarefa> AtualizarTarefa(Tarefa tarefa)
        {
            var obj = await _context.Tarefas.AsNoTracking().FirstOrDefaultAsync(x => x.Id == tarefa.Id);

            if (obj == null)
                throw new InvalidOperationException("Tarefa não encodntrada.");

            _context.Tarefas.Update(tarefa);
            await _context.SaveChangesAsync();
            return tarefa;
        }

        public async Task<Tarefa> ExcluirTarefa(int id)
        {
            var tarefa = await _context.Tarefas.FirstOrDefaultAsync(x => x.Id == id);

            if (tarefa == null)
                throw new InvalidOperationException("Tarefa não encodntrada.");

            _context.Tarefas.Remove(tarefa);
            await _context.SaveChangesAsync();
            return tarefa;
        }       
    }
}

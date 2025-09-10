using AutoMapper;
using ToDoApp.Application.DTO;
using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.Abstraction;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _repository;
        private readonly IMapper _mapper;

        public TarefaService(ITarefaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TarefaDTO>> Tarefas()
        {
            var tarefas = await _repository.Tarefas();
            return _mapper.Map<IEnumerable<TarefaDTO>>(tarefas);
        }

        public async Task<TarefaDTO> TarefaById(int id)
        {
            var cliente = await _repository.TarefaById(id);
            return _mapper.Map<TarefaDTO>(cliente);
        }

        public async Task<TarefaDTO> CriarTarefa(TarefaDTO tarefaDTO)
        {
            var tarefa = _mapper.Map<Tarefa>(tarefaDTO);
            var tarefaCriada = await _repository.CriarTarefa(tarefa);
            return _mapper.Map<TarefaDTO>(tarefaCriada);
        }

        public async Task<TarefaDTO> AtualizarTarefa(TarefaDTO tarefaDTO)
        {
            var tarefa = _mapper.Map<Tarefa>(tarefaDTO);
            var tarefaAlterada = await _repository.AtualizarTarefa(tarefa);
            return _mapper.Map<TarefaDTO>(tarefaAlterada);
        }

        public async Task<TarefaDTO> ExcluirTarefa(int id)
        {
            var tarefaExcluida = await _repository.ExcluirTarefa(id);
            return _mapper.Map<TarefaDTO>(tarefaExcluida);
        }
    }
}

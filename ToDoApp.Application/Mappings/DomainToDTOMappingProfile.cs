using AutoMapper;
using ToDoApp.Application.DTO;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Tarefa, TarefaDTO>().ReverseMap();
        }
    }
}

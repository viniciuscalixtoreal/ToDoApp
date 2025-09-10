using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ToDoApp.Application.DTO
{
    public class TarefaDTO
    {
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Concluida { get; set; }
    }
}

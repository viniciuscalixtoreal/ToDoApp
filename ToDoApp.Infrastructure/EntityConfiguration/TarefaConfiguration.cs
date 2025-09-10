using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Infrastructure.EntityConfiguration
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Titulo).IsRequired();
            builder.Property(m => m.Descricao);
            builder.Property(m => m.DataCriacao);
            builder.Property(m => m.Concluida);
        }
    }
}

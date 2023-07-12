using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Infrastructure.Data.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Pessoa");
            
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Id)
                .HasColumnName("IdPessoa")
                .UseIdentityColumn();

            builder.Property(c => c.Name)
                .HasColumnName("Nome");

            builder.Property(c => c.Document)
                .HasColumnName("Documento");

            builder.Property(c => c.Phone)
                .HasColumnName("Celular");

            builder.HasMany(c => c.Purchases)
                .WithOne(p => p.Person)
                .HasForeignKey(p => p.PersonId);
                
        }
    }
}

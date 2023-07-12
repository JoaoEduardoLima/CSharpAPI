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
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("IdProduto")
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .HasColumnName("Nome");

            builder.Property(x => x.Price)
                .HasColumnName("Preco");

            builder.HasMany(x => x.Purchases)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.ProductId);


        }
    }
}

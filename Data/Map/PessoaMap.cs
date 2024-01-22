using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webAPI.Models;    

namespace webAPI.Data.Map
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(x => x.PessoaID);
            builder.Property(x => x.PessoaNome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaCPF).IsRequired().HasMaxLength(14);
            builder.Property(x => x.PessoaAtivo).IsRequired().HasMaxLength(2);
            builder.Property(x => x.PessoaAniversario).IsRequired().HasMaxLength(12);
        }
    }
}

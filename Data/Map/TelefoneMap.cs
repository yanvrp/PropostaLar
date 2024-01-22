using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webAPI.Models;    

namespace webAPI.Data.Map
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(x => x.TelefoneId);
            builder.Property(x => x.TelefoneNumero).IsRequired().HasMaxLength(15);
            builder.Property(x => x.TelefoneDescricao).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PessoaID).HasMaxLength(10);

            builder.HasOne(x => x.pessoa);
        }
    }
}

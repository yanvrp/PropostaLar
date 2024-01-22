using Microsoft.EntityFrameworkCore;
using webAPI.Models;
using webAPI.Data.Map;
namespace webAPI.Data
{
    public class CadastroPessosasDBContex : DbContext
    {
       public CadastroPessosasDBContex(DbContextOptions<CadastroPessosasDBContex> options) : base(options) 
       {
            
       }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new TelefoneMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

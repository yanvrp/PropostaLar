using Microsoft.EntityFrameworkCore;
using webAPI.Data;
using webAPI.Models;
using webAPI.Repositorios.Interfaces;

namespace webAPI.Repositorios
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private readonly CadastroPessosasDBContex _dbConstext;
        public PessoaRepositorio(CadastroPessosasDBContex cadastroPessosasDBContex)
        {
            _dbConstext = cadastroPessosasDBContex;
        }
        public async Task<Pessoa> BuscarPorID(int ID)
        {
            return await _dbConstext.Pessoas.FirstOrDefaultAsync(x => x.PessoaID == ID);
        }

        public async Task<List<Pessoa>> BuscarTodasPessoas()
        {
            return await _dbConstext.Pessoas.ToListAsync();
        }
        public async Task<Pessoa> Adicionar(Pessoa pessoa)
        {
            await _dbConstext.Pessoas.AddAsync(pessoa);
            await _dbConstext.SaveChangesAsync();
            return pessoa;
        }
        public async Task<Pessoa> Atualizar(Pessoa pessoa, int id)
        {
            Pessoa pessoaPorID = await BuscarPorID(id);
            if(pessoaPorID == null)
            {
                throw new Exception("Usuario para o ID: {id} não foi encontrado no banco de dados");
            }
            pessoaPorID.PessoaNome = pessoa.PessoaNome;
            pessoaPorID.PessoaCPF = pessoa.PessoaCPF;
            pessoaPorID.PessoaAniversario = pessoa.PessoaAniversario;
            pessoaPorID.PessoaAtivo = pessoa.PessoaAtivo;
            _dbConstext.Pessoas.Update(pessoaPorID);
            await _dbConstext.SaveChangesAsync();
            return pessoaPorID;
        }
        public async Task<bool> Apagar(int ID)
        {
            Pessoa pessoaPorID = await BuscarPorID(ID);
            if (pessoaPorID == null)
            {
                throw new Exception("Usuario para o ID: {id} não foi encontrado no banco de dados");
            }
            _dbConstext.Pessoas.Remove(pessoaPorID);
            await _dbConstext.SaveChangesAsync();
            return true;
        }
    }
}

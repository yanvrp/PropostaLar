using Microsoft.EntityFrameworkCore;
using webAPI.Data;
using webAPI.Models;
using webAPI.Repositorios.Interfaces;

namespace webAPI.Repositorios
{
    public class TelefoneRepositorio : ITelefoneRepositorio
    {
        private readonly CadastroPessosasDBContex _dbConstext;
        public TelefoneRepositorio(CadastroPessosasDBContex cadastroPessosasDBContex)
        {
            _dbConstext = cadastroPessosasDBContex;
        }
        public async Task<Telefone> BuscarPorID(int ID)
        {
            return await _dbConstext.Telefones.FirstOrDefaultAsync(x => x.TelefoneId == ID);
        }

        public async Task<List<Telefone>> BuscarTodosTelefones()
        {
            return await _dbConstext.Telefones.ToListAsync();
        }
        public async Task<Telefone> Adicionar(Telefone telefone)
        {
            await _dbConstext.Telefones.AddAsync(telefone);
            await _dbConstext.SaveChangesAsync();
            return telefone;
        }
        public async Task<Telefone> Atualizar(Telefone telefone, int id)
        {
            Telefone telefonePorID = await BuscarPorID(id);
            if(telefonePorID == null)
            {
                throw new Exception("Usuario para o ID: {id} não foi encontrado no banco de dados");
            }
            telefonePorID.TelefoneNumero = telefone.TelefoneNumero;
            telefonePorID.TelefoneDescricao = telefone.TelefoneDescricao;
            telefonePorID.PessoaID = telefone.PessoaID;

            _dbConstext.Telefones.Update(telefonePorID);
            await _dbConstext.SaveChangesAsync();
            return telefonePorID;
        }
        public async Task<bool> Apagar(int ID)
        {
            Telefone telefonePorID = await BuscarPorID(ID);
            if (telefonePorID == null)
            {
                throw new Exception("Telefone para o ID: {id} não foi encontrado no banco de dados");
            }
            _dbConstext.Telefones.Remove(telefonePorID);
            await _dbConstext.SaveChangesAsync();
            return true;
        }
    }
}

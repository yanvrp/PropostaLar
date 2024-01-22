using webAPI.Models;
namespace webAPI.Repositorios.Interfaces
{
    public interface IPessoaRepositorio
    {
        Task<List<Pessoa>> BuscarTodasPessoas();
        Task<Pessoa> BuscarPorID(int ID);
        Task<Pessoa> Adicionar(Pessoa pessoa);
        Task<Pessoa> Atualizar(Pessoa pessoa, int id);
        Task<bool> Apagar(int ID);

    }
}

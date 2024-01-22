using webAPI.Models;
namespace webAPI.Repositorios.Interfaces
{
    public interface ITelefoneRepositorio
    {
        Task<List<Telefone>> BuscarTodosTelefones();
        Task<Telefone> BuscarPorID(int ID);
        Task<Telefone> Adicionar(Telefone telefone);
        Task<Telefone> Atualizar(Telefone telefone, int id);
        Task<bool> Apagar(int ID);

    }
}

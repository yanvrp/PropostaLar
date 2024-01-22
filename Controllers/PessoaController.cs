using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPI.Models;
using webAPI.Repositorios.Interfaces;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        public PessoaController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<Pessoa>>> BuscarTodasPessoas()
        {
            List<Pessoa> pessoas = await _pessoaRepositorio.BuscarTodasPessoas();
            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Pessoa>>> BuscarPorID(int id)
        {
            Pessoa pessoa = await _pessoaRepositorio.BuscarPorID(id);
            return Ok(pessoa);
        }

        [HttpPost]
        public async Task<ActionResult<Pessoa>> Cadastrar([FromBody] Pessoa pPessoa)
        {
            Pessoa pessoa = await _pessoaRepositorio.Adicionar(pPessoa);
            return Ok(pessoa);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Pessoa>> Atualizar([FromBody] Pessoa pPessoa,int id)
        {
            pPessoa.PessoaID = id;
            Pessoa pessoa = await _pessoaRepositorio.Atualizar(pPessoa, id);
            return Ok(pessoa);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Pessoa>> Apagar(int id)
        {
            bool apagado = await _pessoaRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}

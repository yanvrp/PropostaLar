using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPI.Models;
using webAPI.Repositorios;
using webAPI.Repositorios.Interfaces;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefoneController : ControllerBase
    {
        private readonly ITelefoneRepositorio _telefoneRepositorio;
        public TelefoneController(ITelefoneRepositorio telefoneRepositorio)
        {
            _telefoneRepositorio = telefoneRepositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<Telefone>>> BuscarTodosTelefones()
        {
            List<Telefone> telefones = await _telefoneRepositorio.BuscarTodosTelefones();
            return Ok(telefones);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Telefone>>> BuscarPorID(int id)
        {
            Telefone telefone = await _telefoneRepositorio.BuscarPorID(id);
            return Ok(telefone);
        }

        [HttpPost]
        public async Task<ActionResult<Telefone>> Cadastrar([FromBody] Telefone pTelefone)
        {
            Telefone telefone = await _telefoneRepositorio.Adicionar(pTelefone);
            return Ok(telefone);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Telefone>> Atualizar([FromBody] Telefone pTelefone, int id)
        {
            pTelefone.TelefoneId = id;
            Telefone telefone = await _telefoneRepositorio.Atualizar(pTelefone, id);
            return Ok(telefone);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Telefone>> Apagar(int id)
        {
            bool apagado = await _telefoneRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}

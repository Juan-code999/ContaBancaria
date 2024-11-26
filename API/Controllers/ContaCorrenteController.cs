using Contas_Bancaria.Entidades;
using Contas_Bancaria.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly IContaCorrenteService _service;

        public ContaCorrenteController(IContaCorrenteService service)
        {
            _service = service;
        }

        [HttpPost("Adicionar-Conta-Corrente")]
        public void AdicionarAluno(ContaCorrente carrinho)
        {
            _service.Adicionar(carrinho);
        }
        [HttpGet("Listar-Conta-Corrente")]
        public List<ContaCorrente> ListarAluno()
        {
            return _service.Listar();
        }


        [HttpPut("Editar-Conta-Corrente")]
        public void EditarCarrinho(ContaCorrente p)
        {
            _service.Editar(p);
        }
        [HttpDelete("Deletar-Conta-Corrente")]
        public void DeletarCarrinho(int id)
        {
            _service.Remover(id);
        }
    }
}

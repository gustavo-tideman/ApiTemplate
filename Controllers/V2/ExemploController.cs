using ApiTemplate.Data.Sample;
using ApiTemplate.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiTemplate.Controllers.V2
{    
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/Exemplo")]
    public class ExemploController : MainController
    {
        //private readonly IUseInjecaoDependencia _useInjecaoDependencia;

        public ExemploController(INotificador notificador, IUser user) : base(notificador, user)
        {
            //Use injeção de dependência. Esse método estático é apenas para demonstração. Sempre evite acoplamento.
        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            var fornededor = Fornecedor.GerarListaDados();
            return CustomResponse(fornededor);
        }

        [HttpGet("Obter{id:int}")]
        public IActionResult Obter(int id)
        {
            var fornecedor = Fornecedor.GerarDado(id);
            return CustomResponse(fornecedor);
        }

        [HttpPost("Adicionar")]
        public IActionResult Adicionar()
        {
            return Ok();
        }
        
        [HttpPut("Atualizar{id:int}")]
        public IActionResult Atualizar(int id)
        {
            return Ok();
        }
        
        [HttpDelete("Remover{id:int}")]
        public IActionResult Remover(int id)
        {
            return Ok();
        }
    }
}
using Hospedagem.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospedagem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacoesController : ControllerBase
    {
        [HttpPost]
        public IActionResult SimularEntrada([FromBody] RequisicaoEntrada entrada)
        {
            if (entrada == null || string.IsNullOrEmpty(entrada.NomeProduto))
            {
                return BadRequest("Dados de entrada necessários ou nome do produto ausente!");
            }

            if (entrada.Quantidade <= 0 || entrada.PrecoCusto <= 0)
            {
                return BadRequest(new {erro = "Quantidade e preço devem ser maiores que 0!" });
            }




            decimal custoTotal = entrada.Quantidade * entrada.PrecoCusto;
            var resposta = new
            {
                mensagem = "Simulacao de custo total efetuada com sucesso.",
                produto = entrada.NomeProduto,
                custoTotal = custoTotal,
                dataSimulacao = DateTime.Now
            };

            return Ok(custoTotal);
        }

    }
}

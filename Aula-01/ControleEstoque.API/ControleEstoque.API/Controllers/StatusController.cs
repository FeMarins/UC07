using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public string GetStatus()
        {
            return "API retornou com sucesso!";
        }
        [HttpGet("saudacao/{operador}")]
        public string obterSaudacaoRota(string operador)
        {
            return "Olá "+ operador +"!Bem vindo ao Sistema.";
        }
        [HttpGet("consulta")]
        public string ConsultaModulo([FromQuery] string? modulo)
        {
            if (string.IsNullOrEmpty(modulo))
            {
                return "Consultou a lista com todos os modulos";
            }

            return "Você está consultando o módulo: " + modulo;
        }
    }
}

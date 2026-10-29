using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospedagem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PousadaController : ControllerBase
    {
        [HttpGet]
        public string obterStatus()
        {
            return "Sistema de Gerenciamento da Pousada Vista Bela em operação.";
        }
        [HttpGet ("boas-vindas/{nomeHospede}")]
        public string BoasVindasHospede(string nomeHospede)
        {
            return $"Seja muito bem-vindo(a) a Pousada Vista Bela,{nomeHospede} Desejamos uma excelente estadia.";
        }
        [HttpGet("Unidade")]
        public string ConsultarUnidade([FromQuery]string? numeroChale)
        {
            if(numeroChale == null || numeroChale == "")
            {
                return "Chale não informado,redirecionado para o atendimento";
            }
            return $"Unidade Chale {numeroChale} selecionada para atendimento.";
        }

    }
}

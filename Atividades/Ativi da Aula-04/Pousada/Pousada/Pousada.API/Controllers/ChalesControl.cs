using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pousada.API.Data;
using Pousada.API.Models;

namespace Pousada.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChalesControllers : ControllerBase
    {

        AppDbContext _dbcontext;

        public ChalesControllers(AppDbContext context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbcontext.chales);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var chalesBuscado = _dbcontext.chales.FirstOrDefault(itm => itm.Id == id);

            if (chalesBuscado == null)
            {
                return NotFound($"Item nao localizado para o id {id}.");
            }

            return Ok(chalesBuscado);
        }

        [HttpGet("porNome/{nome}")]
        public IActionResult GetByNome(string localizacao)
        {
            var chalesBuscado = _dbcontext.chales.FirstOrDefault(itm => itm.Localizacao == localizacao);

            if (chalesBuscado == null)
            {
                return NotFound($"Item nao localizado para o id {localizacao}.");
            }

            return Ok(chalesBuscado);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Chales novoChales)
        {
            if (novoChales == null || string.IsNullOrWhiteSpace(novoChales.Localizacao))
            {
                return BadRequest("Informa esses dados direito!");
            }

            if (novoChales.ValorBaixaEstacao <= 0  || novoChales.ValorAltaEstacao <=0)
            {
                return BadRequest("De graça nem injeção na testa.");
            }

            _dbcontext.chales.Add(novoChales);
            _dbcontext.SaveChanges();


            return Ok("criado");
        }


       
    }
}
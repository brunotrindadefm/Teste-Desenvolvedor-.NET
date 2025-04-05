using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscricaoController : ControllerBase
    {
        private readonly IInscricaoService _service;

        public InscricaoController(IInscricaoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Inscricao inscricao)
        {
            await _service.AddAsync(inscricao);
            return CreatedAtAction(nameof(GetById), new { id = inscricao.Id }, inscricao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Inscricao inscricao)
        {
            if (id != inscricao.Id) return BadRequest();
            await _service.UpdateAsync(inscricao);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("por-cpf/{cpf}")]
        public async Task<IActionResult> GetByCpf(string cpf)
        {
            var result = await _service.GetByCpfAsync(cpf);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("por-oferta/{id}")]
        public async Task<IActionResult> GetByOfertaId(int id)
        {
            var result = await _service.GetByOfertaIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }


        [HttpGet("tudo-por-cpf/{cpf}")]
        public async Task<IActionResult> GetAllByCpf(string cpf)
        {
            var result = await _service.GetAllByCpfAsync(cpf);
            if (result == null) return NotFound();
            return Ok(result);
        }
    }
}

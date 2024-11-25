using gerenciamentodeprofissionais.Models;
using gerenciamentodeprofissionais.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace gerenciamentodeprofissionais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissionalController : ControllerBase
    {
        private readonly IProfissionalRepository _profissionalRepository;
       

        public ProfissionalController(IProfissionalRepository profissionalRepository)
        {
            _profissionalRepository = profissionalRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Profissional>>> BuscarTodosProfissionais()
        {
            List<Profissional> profissionais = await _profissionalRepository.GetProfissionais();
            return Ok(profissionais);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Profissional>> BuscarPorId(int id)
        {
            Profissional profissional = await _profissionalRepository.GetProfissionalById(id);
            if (profissional == null)
                return NotFound($"Profissional com ID {id} não encontrado.");
            return Ok(profissional);
        }
        [HttpPost]
        public async Task<ActionResult<Profissional>> CadastrarProfissional([FromBody] Profissional profissional)
        {
            Profissional novoProfissional = await _profissionalRepository.AddProfissional(profissional);
            return Ok(novoProfissional);
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult<Profissional>> Atualizar([FromBody] Profissional profissional, int id)
        {
            try
            {
                Profissional profissionalAtualizado = await _profissionalRepository.UpdateProfissional(profissional, id);
                return Ok(profissionalAtualizado);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Apagar(int id)
        {
            try
            {
                bool deletado = await _profissionalRepository.DeleteProfissional(id);
                return Ok(deletado);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}


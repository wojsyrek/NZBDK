using Microsoft.AspNetCore.Mvc;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Controllers
{
    [ApiController]
    [Route("Api/[Controller]/")]
    public class VariantController : Controller
    {
        private readonly IRepositoryWorker _repositoryWorker;

        public VariantController(IRepositoryWorker repositoryWorker)
        {
            _repositoryWorker = repositoryWorker;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(Variant entity)
        {
            await _repositoryWorker.VariantRepository.Add(entity);
            return Ok();
        }
        [HttpPost("GetSpecific")]
        public async Task<IActionResult> GetSpecific(Sygnature entity)
        {
            return Ok(await _repositoryWorker.VariantRepository.GetSpecific(entity));
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(Variant entity)
        {
            await _repositoryWorker.VariantRepository.Update(entity);
            return Ok();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Variant variant)
        {
            await _repositoryWorker.VariantRepository.Delete(variant);
            return Ok();
        }
    }
}

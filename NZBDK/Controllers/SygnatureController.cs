using Microsoft.AspNetCore.Mvc;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Controllers
{
    [ApiController]
    [Route("Api/[Controller]/")]
    public class SygnatureController : Controller
    {
        private readonly IRepositoryWorker _repositoryWorker;

        public SygnatureController(IRepositoryWorker repositoryWorker)
        {
            _repositoryWorker = repositoryWorker;
        }
        [HttpPost("GetSpecific")]
        public async Task<IActionResult> GetSpecific(Segment entity)
        {
            return Ok(await _repositoryWorker.SygnatureRepository.GetSpecific(entity));
        }
        [Helpers.Authorize]
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody]Sygnature entity)
        {
            await _repositoryWorker.SygnatureRepository.Add(entity);
            return Ok();
        }
        [Helpers.Authorize]
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Sygnature entity)
        {
            await _repositoryWorker.SygnatureRepository.Delete(entity);
            return Ok();
        }
        [Helpers.Authorize]
        [HttpPut("Update")]
        public async Task<IActionResult> Update(Sygnature sygnature)
        {
            await _repositoryWorker.SygnatureRepository.Update(sygnature);
            return Ok();
        }
        
    }
}

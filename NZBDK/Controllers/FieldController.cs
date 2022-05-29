using Microsoft.AspNetCore.Mvc;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Controllers
{   
    [ApiController]
    [Route("Api/[Controller]/")]
    public class FieldController : Controller
    {
        private readonly IRepositoryWorker _repositoryWorker;

        public FieldController(IRepositoryWorker repositoryWorker)
        {
            _repositoryWorker = repositoryWorker;
        }
        [Helpers.Authorize]
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody]Field entity)
        {
            await _repositoryWorker.FieldRepository.Add(entity);
            return Ok();
        }
        [Helpers.Authorize]
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Field entity)
        {
            await _repositoryWorker.FieldRepository.Delete(entity);
            return Ok();
        }
        [Helpers.Authorize]
        [HttpPut("Update")]
        public async Task<IActionResult> Update(Field entity)
        {
            await _repositoryWorker.FieldRepository.Update(entity);
            return Ok();
        }
        [HttpPost("GetSpecific")]
        public async Task<IActionResult> GetSpecific(Variant variant)
        {
            return Ok(await _repositoryWorker.FieldRepository.GetSpecific(variant));
        }
    }
}

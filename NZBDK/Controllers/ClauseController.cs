using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Controllers
{
    [ApiController]
    [Route("Api/[Controller]/")]
    public class ClauseController : Controller
    {
        private readonly IRepositoryWorker _repositoryWorker;

        public ClauseController(IRepositoryWorker repositoryWorker)
        {
            _repositoryWorker = repositoryWorker;
        }

        [Helpers.Authorize]
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody]Clause entity)
        {
            await _repositoryWorker.ClauseRepository.Add(entity);
            return Ok();
        }
        [HttpPost("GetSpecific")]
        public async Task<IActionResult> GetSpecific([FromBody]string name)
        {
            return Ok(await _repositoryWorker.ClauseRepository.GetSpecific(name));
        }
        [HttpPost("GetSingle")]
        public async Task<IActionResult> GetSingle([FromBody]int id)
        {
            return Ok(await _repositoryWorker.ClauseRepository.GetSingle(id));
        }
        [HttpPost("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repositoryWorker.ClauseRepository.GetAll());
        }

        [Helpers.Authorize]
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody]Clause entity)
        {
            await _repositoryWorker.ClauseRepository.Update(entity);
            return Ok();
        }
        [Helpers.Authorize]
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody]Clause entity)
        {
            await _repositoryWorker.ClauseRepository.Delete(entity);
            return Ok();
        }
    }
}

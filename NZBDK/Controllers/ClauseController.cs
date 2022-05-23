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

        [HttpPost("Add")]
        public async Task<IActionResult> Add(Clause entity)
        {
            await _repositoryWorker.ClauseRepository.Add(entity);
            return Ok();
        }
        [HttpPost("GetSpecific")]
        public async Task<IActionResult> GetSpecific(string name)
        {
            return Ok(await _repositoryWorker.ClauseRepository.GetSpecific(name));
        }
        [HttpPost("GetSingle")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _repositoryWorker.ClauseRepository.GetSingle(id));
        }
        [HttpPost("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repositoryWorker.ClauseRepository.GetAll());
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(Clause entity)
        {
            await _repositoryWorker.ClauseRepository.Update(entity);
            return Ok();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Clause entity)
        {
            await _repositoryWorker.ClauseRepository.Delete(entity);
            return Ok();
        }
    }
}

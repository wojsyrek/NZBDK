using Microsoft.AspNetCore.Mvc;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Controllers
{
    [ApiController]
    [Route("Api/[Controller]/")]
    public class LoginController : Controller
    {
        private readonly IRepositoryWorker _repositoryWorker;

        public LoginController(IRepositoryWorker repositoryWorker)
        {
            _repositoryWorker = repositoryWorker;
        }
        [Helpers.Authorize]
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody]Login entity)
        {
            await _repositoryWorker.LoginRepository.Add(entity);
            return Ok();
        }
        [HttpPost("GetSpecific")]
        public async Task<IActionResult> GetSpecific([FromBody] string name)
        {
            return Ok(await _repositoryWorker.LoginRepository.GetSpecific(name));
        }
        [HttpPost("GetSingle")]
        public async Task<IActionResult> GetSingle([FromBody] int id)
        {
            return Ok(await _repositoryWorker.LoginRepository.GetSingle(id));
        }
        [HttpPost("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repositoryWorker.LoginRepository.GetAll());
        }
        [Helpers.Authorize]
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] Login entity)
        {
            await _repositoryWorker.LoginRepository.Update(entity);
            return Ok();
        }
        [Helpers.Authorize]
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] Login entity)
        {
            await _repositoryWorker.LoginRepository.Delete(entity);
            return Ok();
        }
    }
}

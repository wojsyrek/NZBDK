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

        [HttpPost("Add")]
        public async Task<IActionResult> Add(Login entity)
        {
            await _repositoryWorker.LoginRepository.Add(entity);
            return Ok();
        }
        [HttpPost("GetSpecific")]
        public async Task<IActionResult> GetSpecific(string name)
        {
            return Ok(await _repositoryWorker.LoginRepository.GetSpecific(name));
        }
        [HttpPost("GetSingle")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _repositoryWorker.LoginRepository.GetSingle(id));
        }
        [HttpPost("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repositoryWorker.LoginRepository.GetAll());
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(Login entity)
        {
            await _repositoryWorker.LoginRepository.Update(entity);
            return Ok();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Login entity)
        {
            await _repositoryWorker.LoginRepository.Delete(entity);
            return Ok();
        }
    }
}

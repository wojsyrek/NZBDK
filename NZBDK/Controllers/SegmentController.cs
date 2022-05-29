using Microsoft.AspNetCore.Mvc;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Controllers
{
    [ApiController]
    [Route("Api/[Controller]/")]
    public class SegmentController : Controller
    {
        private readonly IRepositoryWorker _repositoryWorker;

        public SegmentController(IRepositoryWorker repositoryWorker)
        {
            _repositoryWorker = repositoryWorker;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repositoryWorker.SegmentRepository.GetAll());
        }
        [Helpers.Authorize]
        [HttpPost("Add")]
        public async Task<IActionResult> Add(Segment entity)
        {
            await _repositoryWorker.SegmentRepository.Add(entity);
            return Ok();
        }
        [Helpers.Authorize]
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Segment entity)
        {
            await _repositoryWorker.SegmentRepository.Delete(entity);
            return Ok();
        }
        [Helpers.Authorize]
        [HttpPut("Update")]
        public async Task <IActionResult> Update(Segment entity)
        {
            await _repositoryWorker.SegmentRepository.Update(entity);
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using proekt.Models;
using proekt.Services.Repositories;
using proekt.Interfaces;
namespace proekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultantsController : ControllerBase
    {
        private readonly IRRequest _requestRepository;

        public ConsultantsController(IRRequest requestRepository)
        {
            _requestRepository = requestRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Request>>> GetRequests()
        {
            return await _requestRepository.GetAllRequests();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetRequest(int id)
        {
            var task = await _requestRepository.GetRequestById(id);
            if (task == null) return NotFound();
            return task;
        }

        [HttpPost]
        public async Task<ActionResult> CreateRequest(Request task)
        {
            await _requestRepository.CreateRequest(task);
            return CreatedAtAction(nameof(GetRequest), new { id = task.id }, task);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateRequest(int id, Request task)
        {
            if (id != task.id) return BadRequest();
            await _requestRepository.UpdateRequest(task);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRequest(int id)
        {
            await _requestRepository.DeleteRequest(id);
            return NoContent();
        }
    }
}

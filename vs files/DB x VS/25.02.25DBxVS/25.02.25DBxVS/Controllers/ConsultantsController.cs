using _25._02._25DBxVS.Models;
using Microsoft.AspNetCore.Mvc;
using _25._02._25DBxVS.Interfaces;

namespace _25._02._25DBxVS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultantsController : ControllerBase
    {
        private readonly IConsultantsRepository _taskRepository;

        public ConsultantsController(IConsultantsRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<consultants>>> GetTasks()
        {
            return await _taskRepository.GetAllTasks();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<consultants>> GetTask(int id)
        {
            var task = await _taskRepository.GetTaskById(id);
            if (task == null) return NotFound();
            return task;
        }

        [HttpPost]
        public async Task<ActionResult> CreateTask(consultants task)
        {
            await _taskRepository.CreateTask(task);
            return CreatedAtAction(nameof(GetTask), new { id = task.id }, task);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTask(int id, consultants task)
        {
            if (id != task.id) return BadRequest();
            await _taskRepository.UpdateTask(task);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTask(int id)
        {
            await _taskRepository.DeleteTask(id);
            return NoContent();
        }
    }
}


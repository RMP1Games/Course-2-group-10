using _25._02._25DBxVS.Models;
using Microsoft.AspNetCore.Mvc;
using _25._02._25DBxVS.Interfaces;

namespace _25._02._25DBxVS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        private readonly IWorkersRepository _taskRepository;

        public WorkersController(IWorkersRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<workers>>> GetTasks()
        {
            return await _taskRepository.GetAllTasks();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<workers>> GetTask(int id)
        {
            var task = await _taskRepository.GetTaskById(id);
            if (task == null) return NotFound();
            return task;
        }

        [HttpPost]
        public async Task<ActionResult> CreateTask(workers task)
        {
            await _taskRepository.CreateTask(task);
            return CreatedAtAction(nameof(GetTask), new { id = task.id }, task);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTask(int id, workers task)
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


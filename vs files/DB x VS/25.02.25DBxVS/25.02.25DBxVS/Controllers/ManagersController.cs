using _25._02._25DBxVS.Models;
using Microsoft.AspNetCore.Mvc;
using static Azure.Core.HttpHeader;

namespace _25._02._25DBxVS.Controllers
{
    //services.AddScoped<IManagersRepository, ManagersRepository>();
    [Route("api/[controller]")]
    [ApiController]
    public class ManagersController : ControllerBase
    {
        private readonly IManagersRepository _taskRepository;

        public ManagersController(IManagersRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<managers>>> GetTasks()
        {
            return await _taskRepository.GetAllTasks();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<managers>> GetTask(int id)
        {
            var task = await _taskRepository.GetTaskById(id);
            if (task == null) return NotFound();
            return task;
        }

        [HttpPost]
        public async Task<ActionResult> CreateTask(managers task)
        {
            await _taskRepository.CreateTask(task);
            return CreatedAtAction(nameof(GetTask), new { id = task.id }, task);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTask(int id, managers task)
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


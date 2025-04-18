using _25._02._25DBxVS.Models;

namespace _25._02._25DBxVS.Interfaces
{
    public interface IManagersRepository
    {
        Task<List<managers>> GetAllTasks();
        Task<managers> GetTaskById(int id);
        Task CreateTask(managers task);
        Task UpdateTask(managers task);
        Task DeleteTask(int id);
    }
}

using _25._02._25DBxVS.Models;

namespace _25._02._25DBxVS.Interfaces
{
    public interface IWorkersRepository
    {
        Task<List<workers>> GetAllTasks();
        Task<workers> GetTaskById(int id);
        Task CreateTask(workers task);
        Task UpdateTask(workers task);
        Task DeleteTask(int id);
    }
}

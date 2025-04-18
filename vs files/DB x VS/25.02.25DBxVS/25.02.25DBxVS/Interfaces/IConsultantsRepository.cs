using _25._02._25DBxVS.Models;

namespace _25._02._25DBxVS.Interfaces
{
    public interface IConsultantsRepository
    {
        Task<List<consultants>> GetAllTasks();
        Task<consultants> GetTaskById(int id);
        Task CreateTask(consultants task);
        Task UpdateTask(consultants task);
        Task DeleteTask(int id);
    }
}

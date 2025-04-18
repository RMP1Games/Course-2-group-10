using Microsoft.VisualBasic;
using proekt.Models;

namespace proekt.Interfaces
{
    public interface IRRequest
    {
        Task<List<Request>> GetAllRequests();
        Task<Request> GetRequestById(int id);
        Task CreateRequest(Request task);
        Task UpdateRequest(Request task);
        Task DeleteRequest(int id);
    }
}

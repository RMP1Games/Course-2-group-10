using Microsoft.VisualBasic;
using proekt.Models;

namespace proekt.Interfaces
{
    public interface IRComments
    {
        Task<List<string>> GetAllComments(int id);
        Task<string> GetCommentByID(int table_id, int comment_id);
        Task CreateComment(int id, string comment);
        Task UpdateComment(int id, int comment_id, string comment);
        Task DeleteComment(int id, int comment_id);
    }
}

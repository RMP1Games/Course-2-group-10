using Microsoft.VisualBasic;
using proekt.Models;
using proekt.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http.HttpResults;

namespace proekt.Services.Repositories
{
    public class RComments : IRComments
    {
        private readonly AppDbContext _context;
        public RComments(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<string>> GetAllComments(int id)
        {
            var task = await _context.DRequest.FindAsync(id);
            if (task != null)
            {
                List<string> comments = JsonConvert.DeserializeObject<List<string>>("Comments.json");//если бы было больше таблиц, то "Comments.json" заменилось на переменную task с json именем
                return comments;
            }
            else return null;
        }

        public async Task<string> GetCommentByID(int table_id, int comment_id)
        {
            var task = await _context.DRequest.FindAsync(table_id);
            if (task != null)
            {
                List<string> comments = JsonConvert.DeserializeObject<List<string>>("Comments.json");
                return comments[comment_id - 1];
            }
            else return null;
        }
        public async Task CreateComment(int id, string comment)
        {
            var task = await _context.DRequest.FindAsync(id);
            if (task != null)
            {
                List<string> comments = JsonConvert.DeserializeObject<List<string>>("Comments.json");
                comments.Add(comment);
                var a = JsonConvert.SerializeObject(comments);
            }
        }

        public async Task UpdateComment(int id, int comment_id, string comment)
        {
            var task = await _context.DRequest.FindAsync(id);
            if (task != null)
            {
                List<string> comments = JsonConvert.DeserializeObject<List<string>>("Comments.json");
                comments[comment_id-1] = comment;
                var a = JsonConvert.SerializeObject(comments);
            }
        }

        public async Task DeleteComment(int id, int comment_id)
        {
            var task = await _context.DRequest.FindAsync(id);
            if (task != null)
            {
                List<string> comments = JsonConvert.DeserializeObject<List<string>>("Comments.json");
                comments[comment_id - 1] = null;
                var a = JsonConvert.SerializeObject(comments);
            }
        }
    }
}

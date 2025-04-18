using Microsoft.VisualBasic;
using proekt.Models;
using proekt.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace proekt.Services.Repositories
{
    public class RRequest : IRRequest
    {
        private readonly AppDbContext _context;

        public RRequest(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Request>> GetAllRequests() => await _context.DRequest.ToListAsync();

        public async Task<Request> GetRequestById(int id) => await _context.DRequest.FindAsync(id);

        public async Task CreateRequest(Request task)
        {
            await _context.DRequest.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRequest(Request task)
        {
            _context.DRequest.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRequest(int id)
        {
            var task = await _context.DRequest.FindAsync(id);
            if (task != null)
            {
                _context.DRequest.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}

using _25._02._25DBxVS.Interfaces;
using _25._02._25DBxVS.Models;
using Microsoft.EntityFrameworkCore;

namespace _25._02._25DBxVS.Services.Repositories
{
    public class ManagersRepository : IManagersRepository
    {
        private readonly AppDbContext _context;

        public ManagersRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<managers>> GetAllTasks() => await _context.Dmanagers.ToListAsync();

        public async Task<managers> GetTaskById(int id) => await _context.Dmanagers.FindAsync(id);

        public async Task CreateTask(managers task)
        {
            await _context.Dmanagers.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTask(managers task)
        {
            _context.Dmanagers.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTask(int id)
        {
            var task = await _context.Dmanagers.FindAsync(id);
            if (task != null)
            {
                _context.Dmanagers.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}

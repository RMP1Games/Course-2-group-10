using _25._02._25DBxVS.Interfaces;
using _25._02._25DBxVS.Models;
using Microsoft.EntityFrameworkCore;

namespace _25._02._25DBxVS.Services.Repositories
{
    public class WorkersRepository : IWorkersRepository
    {
        private readonly AppDbContext _context;

        public WorkersRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<workers>> GetAllTasks() => await _context.Dworkers.ToListAsync();

        public async Task<workers> GetTaskById(int id) => await _context.Dworkers.FindAsync(id);

        public async Task CreateTask(workers task)
        {
            await _context.Dworkers.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTask(workers task)
        {
            _context.Dworkers.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTask(int id)
        {
            var task = await _context.Dworkers.FindAsync(id);
            if (task != null)
            {
                _context.Dworkers.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}

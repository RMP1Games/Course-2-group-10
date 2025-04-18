using _25._02._25DBxVS.Interfaces;
using _25._02._25DBxVS.Models;
using Microsoft.EntityFrameworkCore;

namespace _25._02._25DBxVS.Services.Repositories
{
    public class ConsultantsRepository : IConsultantsRepository
    {
        private readonly AppDbContext _context;

        public ConsultantsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<consultants>> GetAllTasks() => await _context.Dconsultants.ToListAsync();

        public async Task<consultants> GetTaskById(int id) => await _context.Dconsultants.FindAsync(id);

        public async Task CreateTask(consultants task)
        {
            await _context.Dconsultants.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTask(consultants task)
        {
            _context.Dconsultants.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTask(int id)
        {
            var task = await _context.Dconsultants.FindAsync(id);
            if (task != null)
            {
                _context.Dconsultants.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace _25._02._25DBxVS.Models
{
    //
    //classes
    //
    public class workers
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name_surname { get; set; }
        [Required]
        public string positionn { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public string numberr { get; set; }
        [Required]
        public int salary { get; set; }
    }

    public class consultants(string n_s, string pos, string stat, string numb, int sal)
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name_surname = n_s;
        [Required]
        public string positionn = pos;
        [Required]
        public string status = stat;
        [Required]
        public string numberr = numb;
        [Required]
        public int salary = sal;
        public int penalty { get; set; }
        public string penaltyInfo { get; set; }
    }

    public class managers(string n_s, string pos, string stat, string numb, int sal)
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name_surname = n_s;
        [Required]
        public string specialization { get; set; }
        public string specializationInfo { get; set; }
        [Required]
        public string status = stat;
        [Required]
        public string numberr = numb;
        [Required]
        public int salary = sal;
        public int penalty { get; set; }
        public string penaltyInfo { get; set; }
    }

    //
    //dbcontext
    //

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<workers> Dworkers { get; set; }
        public DbSet<consultants> Dconsultants { get; set; }
        public DbSet<managers> Dmanagers { get; set; }
    }

    //
    //interfaces
    //

    //workers

    public interface IWorkersRepository
    {
        Task<List<workers>> GetAllTasks();
        Task<workers> GetTaskById(int id);
        Task CreateTask(workers task);
        Task UpdateTask(workers task);
        Task DeleteTask(int id);
    }

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

    //consultants

    public interface IConsultantsRepository
    {
        Task<List<consultants>> GetAllTasks();
        Task<consultants> GetTaskById(int id);
        Task CreateTask(consultants task);
        Task UpdateTask(consultants task);
        Task DeleteTask(int id);
    }

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

    //managers

    public interface IManagersRepository
    {
        Task<List<managers>> GetAllTasks();
        Task<managers> GetTaskById(int id);
        Task CreateTask(managers task);
        Task UpdateTask(managers task);
        Task DeleteTask(int id);
    }

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

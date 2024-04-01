using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Data.Migrations;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{

    
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {

            _context = context;

        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _context.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<T> CreateAsync(T entity)
        {
          await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAllAsync()
        {
            var entities = await GetAllAsync();
            foreach (var entity in entities)
            {
                _context.Remove(entity);
            }
           
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);

            if(entity == null)
            {
                Console.WriteLine("Record not found");
            }
            else
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            var entity = await GetAsync(id);
            return entity == null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var entities = await _context.Set<T>().ToListAsync();

            return entities;
        }

        public async Task<T?> GetAsync(int? id)
        {
            if(id == null)
            {
                return null;
            }
            var entity = await _context.Set<T>().FindAsync(id); 

            return entity;
        }


        public async Task UpdateAsync(T entity)
        {
           // _context.Entry(entity).State = EntityState.Modified;

            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}

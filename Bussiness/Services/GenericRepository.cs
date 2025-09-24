using EmpñeaodAPI_SIn_StoreProcedure.Bussiness.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmpñeaodAPI_SIn_StoreProcedure.Bussiness.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContext context) { 
        
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<IEnumerable<T>> ObtenerTodosAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> ObtenerPorIdAsync(Guid id)
        {
           return await _dbSet.FindAsync(id);
        }

        public async Task<T> CrearAsync(T entidad)
        {
            await _dbSet.AddAsync(entidad);
            await _context.SaveChangesAsync();
            return entidad;
        }

        public async Task<T> ActualizarAsync(T entidad)
        {
            _dbSet.Update(entidad);
            await _context.SaveChangesAsync();
            return entidad;
        }

    

        public async Task<bool> EliminarAsync(Guid id)
        {
            var entidad = await _dbSet.FindAsync(id);
            if (entidad == null) return false;

            _dbSet.Remove(entidad);
            await _context.SaveChangesAsync();
            return true;
        }

      

        
    }
}

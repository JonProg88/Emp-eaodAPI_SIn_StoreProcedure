using EmpñeaodAPI_SIn_StoreProcedure.Bussiness.Implementacion;
using EmpñeaodAPI_SIn_StoreProcedure.Data;
using EmpñeaodAPI_SIn_StoreProcedure.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpñeaodAPI_SIn_StoreProcedure.Bussiness.Services
{
    public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleadoReppository
    {
        private readonly EmpleadosDbContext _context;

        public EmpleadoRepository(EmpleadosDbContext context) : base(context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Empleado>> ObtenerPorPuestoAsync(string puesto)
        {
            return await _context.Empleados
                .Where(e => e.Puesto == puesto)
                .ToListAsync();
        }
    }
}

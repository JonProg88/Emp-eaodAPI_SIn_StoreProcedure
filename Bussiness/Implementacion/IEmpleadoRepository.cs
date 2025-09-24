using EmpñeaodAPI_SIn_StoreProcedure.Bussiness.Interfaces;
using EmpñeaodAPI_SIn_StoreProcedure.Models;

namespace EmpñeaodAPI_SIn_StoreProcedure.Bussiness.Implementacion
{
   
        public interface IEmpleadoReppository : IGenericRepository<Empleado>
        {
            Task<IEnumerable<Empleado>> ObtenerPorPuestoAsync(string puesto);
        }

}

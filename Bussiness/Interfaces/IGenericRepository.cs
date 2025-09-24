namespace EmpñeaodAPI_SIn_StoreProcedure.Bussiness.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> ObtenerTodosAsync(); // Obtener todos 
        Task<T?> ObtenerPorIdAsync(Guid id); // Obtener por un dato
        Task<T> CrearAsync(T entidad); // Crear con su Generic ese generic <T> es de una clase del modelo
        Task<T> ActualizarAsync(T entidad); // Actualizar 
        Task<bool> EliminarAsync(Guid entidad); // Eliminar
    }
}

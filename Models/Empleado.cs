namespace EmpñeaodAPI_SIn_StoreProcedure.Models
{
    public class Empleado
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Puesto { get; set; }
        public decimal Salario { get; set; }
    }
}

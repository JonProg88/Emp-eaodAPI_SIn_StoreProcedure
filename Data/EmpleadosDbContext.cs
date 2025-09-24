using EmpñeaodAPI_SIn_StoreProcedure.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmpñeaodAPI_SIn_StoreProcedure.Data
{
    public class EmpleadosDbContext : DbContext
    {
        public EmpleadosDbContext(DbContextOptions<EmpleadosDbContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}

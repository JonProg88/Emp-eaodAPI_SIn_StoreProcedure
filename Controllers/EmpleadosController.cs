using EmpñeaodAPI_SIn_StoreProcedure.Bussiness.Implementacion;
using EmpñeaodAPI_SIn_StoreProcedure.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpñeaodAPI_SIn_StoreProcedure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadosController : Controller
    {
        private readonly IEmpleadoReppository _repo;
        
        public EmpleadosController(IEmpleadoReppository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _repo.ObtenerTodosAsync());


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var empleado = await _repo.ObtenerPorIdAsync(id);
            return empleado is null ? NotFound() : Ok(empleado);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Empleado empleado) =>
            Ok(await _repo.CrearAsync(empleado));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Empleado empleado)
        {
            if(id != empleado.Id) return BadRequest();
            return Ok(await _repo.ActualizarAsync(empleado));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id) =>
            (await _repo.EliminarAsync(id)) ? Ok() : NotFound();


    }
}

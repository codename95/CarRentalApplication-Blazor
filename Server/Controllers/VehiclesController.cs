using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalApp.Server.Data;
using CarRentalApp.Shared.Domain;
using CarRentalApp.Server.IRepository;

namespace CarRentalApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public VehiclesController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            var obj = await _unitofwork.Vehicles.GetAll();
            return Ok(obj);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
            var obj = await _unitofwork.Vehicles.Get(q => q.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle obj)
        {
            if (id != obj.Id)
            {
                return BadRequest();
            }

            _unitofwork.Vehicles.Update(obj);

            try
            {
                await _unitofwork.SaveChangesAsync(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ObjectExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Vehicle>> PutVehicle(Vehicle obj)
        {
            await _unitofwork.Vehicles.Insert(obj);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return CreatedAtAction("GetVehicle", new { id = obj.Id }, obj);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var obj = await _unitofwork.Vehicles.Get(f => f.Id == id);
            if(obj == null)
            {
                return NotFound();
            }

            await _unitofwork.Vehicles.Delete(id);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return NoContent();
        }

        private async  Task<bool> ObjectExists(int id)
        {
            var obj = await _unitofwork.Vehicles.Get(e => e.Id == id);
            return obj != null;
        }
    }
}

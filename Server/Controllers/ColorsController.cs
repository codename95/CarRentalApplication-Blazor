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
    public class ColorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public ColorsController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [HttpGet]
        public async Task<IActionResult> GetColors()
        {
            var obj = await _unitofwork.Colors.GetAll();
            return Ok(obj);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetColor(int id)
        {
            var obj = await _unitofwork.Colors.Get(q => q.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutColor(int id, Color obj)
        {
            if (id != obj.Id)
            {
                return BadRequest();
            }

            _unitofwork.Colors.Update(obj);

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
        public async Task<ActionResult<Color>> PostColor(Color obj)
        {
            await _unitofwork.Colors.Insert(obj);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return CreatedAtAction("GetColor", new { id = obj.Id }, obj);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id)
        {
            var obj = await _unitofwork.Colors.Get(f => f.Id == id);
            if(obj == null)
            {
                return NotFound();
            }

            await _unitofwork.Colors.Delete(id);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return NoContent();
        }

        private async  Task<bool> ObjectExists(int id)
        {
            var obj = await _unitofwork.Colors.Get(e => e.Id == id);
            return obj != null;
        }
    }
}

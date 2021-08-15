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
    public class MakesController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public MakesController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<IActionResult> GetMakes()
        {
            var makes = await _unitofwork.Makes.GetAll();
            return Ok(makes);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMake(int id)
        {
            var make = await _unitofwork.Makes.Get(q => q.Id == id);

            if (make == null)
            {
                return NotFound();
            }

            return Ok(make);
        }

        // PUT: api/Makes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }

            _unitofwork.Makes.Update(make);

            try
            {
                await _unitofwork.SaveChangesAsync(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MakeExists(id))
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

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostMake(Make make)
        {
            await _unitofwork.Makes.Insert(make);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            var make = await _unitofwork.Makes.Get(f => f.Id == id);
            if(make == null)
            {
                return NotFound();
            }

            await _unitofwork.Makes.Delete(id);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return NoContent();
        }

        private async  Task<bool> MakeExists(int id)
        {
            var make = await _unitofwork.Makes.Get(e => e.Id == id);
            return make != null;
        }
    }
}

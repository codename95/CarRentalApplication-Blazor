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
    public class BookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public BookingsController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            var obj = await _unitofwork.Bookings.GetAll();
            return Ok(obj);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var obj = await _unitofwork.Bookings.Get(q => q.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking obj)
        {
            if (id != obj.Id)
            {
                return BadRequest();
            }

            _unitofwork.Bookings.Update(obj);

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
        public async Task<ActionResult<Booking>> PostColor(Booking obj)
        {
            await _unitofwork.Bookings.Insert(obj);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return CreatedAtAction("GetBooking", new { id = obj.Id }, obj);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var obj = await _unitofwork.Bookings.Get(f => f.Id == id);
            if(obj == null)
            {
                return NotFound();
            }

            await _unitofwork.Bookings.Delete(id);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return NoContent();
        }

        private async  Task<bool> ObjectExists(int id)
        {
            var obj = await _unitofwork.Bookings.Get(e => e.Id == id);
            return obj != null;
        }
    }
}

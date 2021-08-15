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
    public class CustomersController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public CustomersController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var obj = await _unitofwork.Customers.GetAll();
            return Ok(obj);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var obj = await _unitofwork.Customers.Get(q => q.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer obj)
        {
            if (id != obj.Id)
            {
                return BadRequest();
            }

            _unitofwork.Customers.Update(obj);

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
        public async Task<ActionResult<Customer>> PutCustomer(Customer obj)
        {
            await _unitofwork.Customers.Insert(obj);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return CreatedAtAction("GetCustomer", new { id = obj.Id }, obj);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var obj = await _unitofwork.Customers.Get(f => f.Id == id);
            if(obj == null)
            {
                return NotFound();
            }

            await _unitofwork.Customers.Delete(id);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return NoContent();
        }

        private async  Task<bool> ObjectExists(int id)
        {
            var obj = await _unitofwork.Customers.Get(e => e.Id == id);
            return obj != null;
        }
    }
}

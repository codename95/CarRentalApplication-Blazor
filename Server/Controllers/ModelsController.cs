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
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public ModelsController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [HttpGet]
        public async Task<IActionResult> GetModel()
        {
            var obj = await _unitofwork.Models.GetAll();
            return Ok(obj);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetModel(int id)
        {
            var obj = await _unitofwork.Models.Get(q => q.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model obj)
        {
            if (id != obj.Id)
            {
                return BadRequest();
            }

            _unitofwork.Models.Update(obj);

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
        public async Task<ActionResult<Model>> PostModel(Model obj)
        {
            await _unitofwork.Models.Insert(obj);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return CreatedAtAction("GetModel", new { id = obj.Id }, obj);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            var obj = await _unitofwork.Models.Get(f => f.Id == id);
            if(obj == null)
            {
                return NotFound();
            }

            await _unitofwork.Models.Delete(id);
            await _unitofwork.SaveChangesAsync(HttpContext);

            return NoContent();
        }

        private async  Task<bool> ObjectExists(int id)
        {
            var obj = await _unitofwork.Models.Get(e => e.Id == id);
            return obj != null;
        }
    }
}

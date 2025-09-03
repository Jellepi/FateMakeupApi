using FateMakeupApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FateMakeupApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakeupController(MakeupDBContext context) : ControllerBase
    {
        private readonly MakeupDBContext _context = context;


        [HttpGet]
        public async Task<ActionResult<List<Makeup>>> GetMakeup()
        {
            return Ok(await _context.Makeups.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Makeup>> GetMakeupById(int id)
        {
            var makeup = await _context.Makeups.FindAsync(id);
            if (makeup == null)
            {
                return NotFound();
            }
            return Ok(makeup);
        }

        [HttpPost]
        public async Task<ActionResult<Makeup>> AddMakeup(Makeup newMakeup)
        {
            if (newMakeup is null)
            {
                return BadRequest();
            }
            _context.Makeups.Add(newMakeup);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMakeupById), new { id = newMakeup.ID }, newMakeup);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMakeup(int id, Makeup updatedMakeup)
        {
            var makeup = await _context.Makeups.FindAsync(id);
            if (makeup == null)
            {
                return NotFound();
            }
            makeup.Name = updatedMakeup.Name;
            makeup.Brand = updatedMakeup.Brand;
            makeup.Type = updatedMakeup.Type;
            makeup.Category = updatedMakeup.Category;
            makeup.Description = updatedMakeup.Description;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMakeup(int id)
        {
            var makeup = await _context.Makeups.FindAsync(id);
            if (makeup == null)
            {
                return NotFound();
            }
            _context.Makeups.Remove(makeup);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}

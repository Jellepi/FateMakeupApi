using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FateMakeupApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakeupController : ControllerBase
    {
        static private List<Makeup> makeups = new List<Makeup>
        {
            new Makeup
            {
                ID = 1,
                Name = "Matte Lipstick",
                Brand = "MAC",
                Type = "Lipstick",
                Category = "Lips",
                Description = "Long-lasting matte finish lipstick in Ruby Woo shade."
            },
            new Makeup
            {
                ID = 2,
                Name = "Liquid Foundation",
                Brand = "Maybelline",
                Type = "Foundation",
                Category = "Face",
                Description = "Lightweight foundation with full coverage and SPF 20."
            },
            new Makeup
            {
                ID = 3,
                Name = "Eyeshadow Palette",
                Brand = "Urban Decay",
                Type = "Eyeshadow",
                Category = "Eyes",
                Description = "12-shade palette featuring warm neutrals and shimmer tones."
            },
            new Makeup
            {
                ID = 4,
                Name = "Volumizing Mascara",
                Brand = "L'Oréal",
                Type = "Mascara",
                Category = "Eyes",
                Description = "Mascara that provides intense volume and length."
            },
            new Makeup
            {
                ID = 5,
                Name = "Blush Powder",
                Brand = "NARS",
                Type = "Blush",
                Category = "Cheeks",
                Description = "Highly pigmented blush in the shade Orgasm."
            }
    };
        
        [HttpGet]
        public ActionResult<Makeup> GetMakeup()
        {
            return Ok(makeups);
        }

        [HttpGet("{id}")]
        public ActionResult<Makeup> GetMakeupById(int id)
        {
            var makeup = makeups.FirstOrDefault(m => m.ID == id);
            if (makeup == null)
            {
                return NotFound();
            }
            return Ok(makeup);
        }

        [HttpPost]
        public ActionResult<Makeup> AddMakeup(Makeup newMakeup)
        {
            if(newMakeup is null)
            {
                return BadRequest();
            }
            newMakeup.ID = makeups.Max(m => m.ID) + 1;
            makeups.Add(newMakeup);
            return CreatedAtAction(nameof(GetMakeupById), new { id = newMakeup.ID }, newMakeup);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMakeup(int id, Makeup updatedMakeup)
        {
            var makeup = makeups.FirstOrDefault(m => m.ID == id);
            if (makeup is null)
            {
                return NotFound();
            }
            makeup.Name = updatedMakeup.Name;
            makeup.Brand = updatedMakeup.Brand;
            makeup.Type = updatedMakeup.Type;
            makeup.Category = updatedMakeup.Category;
            makeup.Description = updatedMakeup.Description;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMakeup(int id)
        {
            var makeup = makeups.FirstOrDefault(m => m.ID == id);
            if (makeup is null)
            {
                return NotFound();
            }
            makeups.Remove(makeup);
            return NoContent();
        }

    }
}

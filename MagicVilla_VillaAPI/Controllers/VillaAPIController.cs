



using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    
    public class VillaAPIController:ControllerBase
    {
        //private readonly ILogger<VillaAPIController> _logger;

        private readonly ApplicationDbContext _db;
        public VillaAPIController(ApplicationDbContext db)

        {
           _db = db;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async  Task<ActionResult<IEnumerable<Villa>>> GetVillas()
        {
           // _logger.LogInformation("Get All villa Information");
            return await _db.Villas.ToListAsync();
        }
      
        [HttpGet("{id:int}",Name="GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var villa = _db.Villas.FirstOrDefault(u => u.Id == id);

            if (villa == null)
            {
                return NotFound();

            }
            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> CreateVilla([FromBody]VillaDTO villaDTO)
        {

            if(_db.Villas.FirstOrDefault(u=>u.Name.ToLower() == villaDTO.Name.ToLower())!= null)
            {
                ModelState.AddModelError("CustomError", "Villa Name Already exists");
                return BadRequest(ModelState);
            }
            if (villaDTO == null)
            {
                return BadRequest();
            }
            if(villaDTO.Id > 0) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Villa model= new()
            {
                Name = villaDTO.Name,
                Id = villaDTO.Id,
                Amenity= villaDTO.Amenity,
                Occupancy= villaDTO.Occupancy,
                Rate= villaDTO.Rate,
                Sqft= villaDTO.Sqft,
                Details= villaDTO.Details,
                ImageUrl= villaDTO.ImageUrl,
            };

            _db.Villas.Add(model);
            _db.SaveChanges();

            return CreatedAtRoute("GetVilla",new {id=villaDTO.Id},villaDTO);
             
        }

        [HttpDelete("{id:int}", Name = "DeleteVilla")]

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteVilla(int id)
        {
            if(id==0)
            {
                return BadRequest();
            }
            var villa=_db.Villas.FirstOrDefault(u=>u.Id==id);
            if(villa==null)
            {
                return NotFound();
            }
            _db.Villas.Remove(villa);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
       
        public IActionResult UpdateVilla(int id,[FromBody]VillaDTO villaDTO)
        {
            if(villaDTO==null ||id!=villaDTO.Id)
            {
                return BadRequest();
            }
            //var villa = _db.Villas.FirstOrDefault(u => u.Id == id);
            //villa.Name=villaDTO.Name;
            //villa.Sqft=villaDTO.Sqft;
            //villa.Occupancy=villaDTO.Occupancy;

            Villa model = new()
            {
                Name = villaDTO.Name,
                Id = villaDTO.Id,
                Amenity = villaDTO.Amenity,
                Occupancy = villaDTO.Occupancy,
                Rate = villaDTO.Rate,
                Sqft = villaDTO.Sqft,
                Details = villaDTO.Details,
                ImageUrl = villaDTO.ImageUrl,
            };

            _db.Villas.Update(model);
            _db.SaveChanges();


            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult UpdatePartialVilla(int id,JsonPatchDocument<VillaDTO> patchDTO)
        {
            if (patchDTO == null || id ==0)
            {
                return BadRequest();
            }
            var villa = _db.Villas.AsNoTracking().FirstOrDefault(u => u.Id == id);

          

            if(villa==null)
            {
                return BadRequest();

            }
            VillaDTO villaDTO = new()
            {
                Name = villa.Name,
                Id = villa.Id,
                Amenity = villa.Amenity,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                Sqft = villa.Sqft,
                Details = villa.Details,
                ImageUrl = villa.ImageUrl,
            };
            patchDTO.ApplyTo(villaDTO, ModelState);
            Villa model = new()
            {
                Name = villaDTO.Name,
                Id = villaDTO.Id,
                Amenity = villaDTO.Amenity,
                Occupancy = villaDTO.Occupancy,
                Rate = villaDTO.Rate,
                Sqft = villaDTO.Sqft,
                Details = villaDTO.Details,
                ImageUrl = villaDTO.ImageUrl,
            };
            _db.Villas.Update(model);
            _db.SaveChanges();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}

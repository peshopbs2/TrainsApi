using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainsApi.Data.Entities;
using TrainsApi.Services.Abstractions;

namespace TrainsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        // GET: api/Locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocations()
        {
            return await _locationService.GetLocationsAsync();
        }

        // GET: api/Locations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id)
        {
            var location = await _locationService.GetLocationByIdAsync(id);

            if (location == null)
            {
                return NotFound();
            }

            return location;
        }

        // GET: api/Locations/ByName/Banichka
        [HttpGet("ByName/{name}")]
        public async Task<ActionResult<Location>> GetLocationByName(string name)
        {
            var location = await _locationService.GetLocationByNameAsync(name);

            if (location == null)
            {
                return NotFound();
            }

            return location;
        }
        // PUT: api/Locations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation(int id, Location location)
        {
            if (id != location.Id)
            {
                return BadRequest();
            }

            await _locationService
                .UpdateLocationAsync(location);

            return NoContent();
        }

        // POST: api/Locations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            await _locationService.AddLocationAsync(location);

            return CreatedAtAction("GetLocation", new { id = location.Id }, location);
        }

        // DELETE: api/Locations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            try
            {
                await _locationService
                    .DeleteLocationByIdAsync(id);
            }
            catch (InvalidOperationException ex)
            {
                throw;
            }
            return NoContent();
        }

    }
}

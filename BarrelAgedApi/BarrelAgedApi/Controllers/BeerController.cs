using BarrelAgedApi.Data;
using BarrelAgedApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BarrelAgedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private readonly Context _context;
        public BeerController(Context context) => _context = context;

        [HttpPost]
        [Route("savebeer")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> saveBeer(Beer request)
        {
            if (request != null)
            {
                await _context.Beers.AddAsync(request);
                await _context.SaveChangesAsync();

                return Ok("beer has been saved");
            }
            return BadRequest("request was null");
        }

        [HttpPost]
        [Route("getbeersbyuserid")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> getBeersByUserId(int id)
        {
            User? user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user != null)
            {
                var beers = await _context.Beers.Where(u => u.userId == id)
                    .ToListAsync();
                return Ok(beers);
            }
            return BadRequest("User not found");
        }
    }
}

using HotelBookingApi.Data;
using HotelBookingApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public HotelsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
    {
        return await _context.Hotels.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Hotel>> GetHotel(int id)
    {
        var hotel = await _context.Hotels.FindAsync(id);

        if (hotel == null)
            return NotFound();

        return hotel;
    }

    [HttpPost]
    public async Task<ActionResult<Hotel>> CreateHotel(Hotel hotel)
    {
        _context.Hotels.Add(hotel);

        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetHotel),
            new { id = hotel.Id },
            hotel);
    }
}

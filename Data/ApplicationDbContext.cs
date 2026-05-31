using Microsoft.EntityFrameworkCore;
using HotelBookingApi.Models;

namespace HotelBookingApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Hotel> Hotels => Set<Hotel>();

    public DbSet<Room> Rooms => Set<Room>();

    public DbSet<Customer> Customers => Set<Customer>();

    public DbSet<Reservation> Reservations => Set<Reservation>();
}

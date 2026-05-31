using HotelBookingApi.Models;

namespace HotelBookingApi.Data;

public static class SeedData
{
    public static List<Hotel> Hotels => new()
    {
        new Hotel
        {
            Id = 1,
            Name = "Grand Hotel",
            City = "Tirana",
            Address = "Center"
        }
    };
}

namespace HotelBookingApi.Models;

public class Room
{
    public int Id { get; set; }

    public string RoomNumber { get; set; } = string.Empty;

    public decimal PricePerNight { get; set; }

    public bool IsAvailable { get; set; }

    public int HotelId { get; set; }

    public Hotel Hotel { get; set; } = null!;
}

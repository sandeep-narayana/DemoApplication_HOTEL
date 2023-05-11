using DemoApplication_HOTEL.DTOs;

namespace DemoApplication_HOTEL.Models;

public record Schedule
{
    public int SchId{get; set;}
    public DateTimeOffset CheckIn{get; set;}
    public DateTimeOffset CheckOut{get; set;}
    public  int GuestCount {get; set;}
    public double Price{get; set;}

    public DateTimeOffset CreatedAt{get; set;}

    public int GuestID{get; set;}
    public int RoomId{get; set;}

    public ScheduleDto asScheduleDto => new ScheduleDto{
        CheckIn = CheckIn,
        CheckOut = CheckOut,
        GuestCount =GuestCount,
        Price = Price,
        CreatedAt = CreatedAt
    };

}
using DemoApplication_HOTEL.Model;

namespace DemoApplication_HOTEL.DTOs;

public record RoomDto
{
    public int RoomId{get; set;}
    public string type{get; set;}
    public int Size{get; set;}
}
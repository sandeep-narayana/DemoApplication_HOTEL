using DemoApplication_HOTEL.Models;

namespace DemoApplication_HOTEL.DTOs;

public record CreateGuestDTO
{
    public string name{get; set;}
    public  long Mobile{get; set;}
    public string Email{get; set;}
    public DateTimeOffset DateOfBirth{get; set;}
    public string Address{get; set;}
    public string Gender{get; set;} 
}


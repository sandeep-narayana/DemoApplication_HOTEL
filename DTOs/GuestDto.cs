using System.Text.Json.Serialization;
using DemoApplication_HOTEL.Models;

namespace DemoApplication_HOTEL.DTOs;

public record GuestDto
{
    public string Name{get; set;}
    public  long Mobile{get; set;}
    public string Email{get; set;}
    [JsonPropertyName("Date_of_birth")]
    public DateTimeOffset DateOfBirth{get; set;}
    public string Address{get; set;}
    public string Gender{get; set;} 

    public List<ScheduleDto> ScheduleDto{get; set;}
}








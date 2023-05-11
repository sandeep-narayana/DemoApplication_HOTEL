

using DemoApplication_HOTEL.DTOs;

namespace DemoApplication_HOTEL.Models;


public enum Gender
{
    Male = 1,
    Female =2
}

public record Guest
{
    public int GuestID{get; set;}
    public string Name{get; set;}
    public  long Mobile{get; set;}
    public string Email{get; set;}
    public DateTimeOffset DateOfBirth{get; set;}
    public string Address{get; set;}
    public Gender Gender{get; set;} 


    public GuestDto asGuestDto => new GuestDto{
        Name = Name,
        Email=Email,
        Mobile = Mobile,
        Address = Address,
    };
}

// method to convert Guest into GuestDTO

namespace DemoApplication_HOTEL.Models;


public enum Gender
{
    Male = 1,
    Female =2
}

public record Guest
{
    public int GuestID{get; set;}
    public string name{get; set;}

    public  long Mobile{get; set;}
    public string Email{get; set;}
    public DateTimeOffset DateOfBirth{get; set;}
    public string Address{get; set;}
    public Gender Gender{get; set;} 
}
namespace DemoApplication_HOTEL.Models;

public enum Shift{
    Day = 1,
    Night = 2
}

public record Staff
{
    public int StaffID{get; set;}
    public string Name{get; set;}
    public DateTimeOffset DateOfBirth{get; set;}
    public Gender Gender{get; set;}

    public int Mobile {get; set;}
    public string Address{get; set;}
    public Shift Shift{get; set;}
}
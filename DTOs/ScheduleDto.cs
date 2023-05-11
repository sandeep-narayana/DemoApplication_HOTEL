using System.Text.Json.Serialization;

namespace DemoApplication_HOTEL.DTOs;

public record ScheduleDto 
{
    [JsonPropertyName("Check_in")]
    public DateTimeOffset CheckIn{get; set;}
    [JsonPropertyName("Check_out")]
    public DateTimeOffset CheckOut{get; set;}
    [JsonPropertyName("guest_count")]
    public  int GuestCount {get; set;}
    public double Price{get; set;}

    public DateTimeOffset CreatedAt{get; set;}

    // public int GuestID{get; set;} // here we need full guest object as we are using it for return
    // public int RoomId{get; set;}  // here we need full room object as we are using it for return

    public RoomDto Room{get; set;}
    public GuestDto Guest{get; set;}

    


}
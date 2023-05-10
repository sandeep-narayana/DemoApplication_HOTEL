namespace DemoApplication_HOTEL.Model;


public enum RoomType
{
    Regular = 1,
    Double = 2,
    Master = 3,
    Suite = 4
}
public record room
{
    public int RoomId{get; set;}
    public RoomType type{get; set;}
    public int Size{get; set;}
    public double Price{get; set;}
    public int StaffId{get; set;}


}
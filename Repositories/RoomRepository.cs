using DemoApplication_HOTEL.Model;

namespace DemoApplication_HOTEL.Repositories;

public interface IRoomRepository
{
    Task<List<room>> GetAll();
    Task<room> GetById(long GuestId);
    Task <string> Create(room guest);
    Task <room> Update(room guest);
    
}

public class RoomRepository : BaseRepository , IRoomRepository
{
    public RoomRepository(IConfiguration configuration) : base(configuration)
    {

    }

    public Task<string> Create(room guest)
    {
        throw new NotImplementedException();
    }

    public Task<List<room>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<room> GetById(long GuestId)
    {
        throw new NotImplementedException();
    }

    public Task<room> Update(room guest)
    {
        throw new NotImplementedException();
    }
}
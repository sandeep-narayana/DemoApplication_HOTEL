using DemoApplication_HOTEL.Models;

namespace DemoApplication_HOTEL.Repositories;

public interface IScheduleRepository
{
    Task<List<Schedule>> GetAll();
    Task<Schedule> GetById(long GuestId);
    Task <string> Create(Schedule guest);
    Task <Schedule> Update(Schedule guest);
    
}

public class ScheduleRepository : BaseRepository,IScheduleRepository 
{
    public ScheduleRepository(IConfiguration configuration) : base(configuration)
    {

    }

    public Task<string> Create(Schedule guest)
    {
        throw new NotImplementedException();
    }

    public Task<List<Schedule>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Schedule> GetById(long GuestId)
    {
        throw new NotImplementedException();
    }

    public Task<Schedule> Update(Schedule guest)
    {
        throw new NotImplementedException();
    }
}
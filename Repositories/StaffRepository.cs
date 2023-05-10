using DemoApplication_HOTEL.Models;

namespace DemoApplication_HOTEL.Repositories;

public interface IStaffRepository
{
    Task<List<Staff>> GetAll();
    Task<Staff> GetById(long GuestId);
    Task <string> Create(Staff guest);
    Task <Schedule> Update(Staff guest);
    
}

public class StaffRepository : BaseRepository,IStaffRepository 
{
    public StaffRepository(IConfiguration configuration) : base(configuration)
    {
        
    }

    public Task<string> Create(Staff guest)
    {
        throw new NotImplementedException();
    }

    public Task<List<Staff>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Staff> GetById(long GuestId)
    {
        throw new NotImplementedException();
    }

    public Task<Schedule> Update(Staff guest)
    {
        throw new NotImplementedException();
    }
}
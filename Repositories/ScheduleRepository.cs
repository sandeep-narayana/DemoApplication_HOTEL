using DemoApplication_HOTEL.Models;
using DemoApplication_HOTEL.utilities;
using Dapper;

namespace DemoApplication_HOTEL.Repositories;

public interface IScheduleRepository
{
    Task<List<Schedule>> GetAll();
    Task<List<Schedule>> GetById(long GuestId);
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

    public async Task<List<Schedule>> GetById(long GuestId)
    {
        var query = @$" SELECT * FROM {TableNames.Schedule} WHERE guest_id = @GuestId";


        using(var con = NewConnection){
            return (await con.QueryAsync<Schedule>(query,new{
                GuestId=GuestId
            })).AsList();
        }

        
    }

    public Task<Schedule> Update(Schedule guest)
    {
        throw new NotImplementedException();
    }
}
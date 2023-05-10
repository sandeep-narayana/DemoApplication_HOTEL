using DemoApplication_HOTEL.Models;
using DemoApplication_HOTEL.utilities;
using Dapper;
using DemoApplication_HOTEL.DTOs;

namespace DemoApplication_HOTEL.Repositories;

public interface IGuestRepository
{
    Task<List<Guest>> GetAll();
    Task<Guest> GetById(long GuestId);
    Task <string> Create(Guest guest);
    Task <Guest> Update(Guest guest);
    
}

public class GuestRepository : BaseRepository,IGuestRepository 
{
    public GuestRepository(IConfiguration configuration) : base(configuration)
    {

    }

    public async Task<string> Create(Guest guest)
    {
        var query = @$"INSERT INTO {TableNames.Guest} (name,mobile,email,date_of_birth,address,gender) VALUES(@Name,@Mobile,@Email,@DateOfBirth,@Address,@Gender)";

        using(var con = NewConnection){
            var res = await con.QueryFirstOrDefaultAsync<Guest>(query,guest);
            return "Guest Created Successfully";
        }
    }

    public async Task<List<Guest>> GetAll()
    {
        var query = @$" SELECT * FROM {TableNames.Guest}";

        List<Guest> guests;

        using(var con = NewConnection)
        {
            guests = (await con.QueryAsync<Guest>(query)).AsList();  
        }
        return guests;
    }

    public Task<Guest> GetById(long GuestId)
    {
        throw new NotImplementedException();
    }

    public Task<Guest> Update(Guest guest)
    {
        throw new NotImplementedException();
    }

    internal Task Create(CreateGuestDTO guest)
    {
        throw new NotImplementedException();
    }
}

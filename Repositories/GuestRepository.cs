using DemoApplication_HOTEL.Models;
using DemoApplication_HOTEL.utilities;
using Dapper;
using DemoApplication_HOTEL.DTOs;

namespace DemoApplication_HOTEL.Repositories;

public interface IGuestRepository
{
    Task<List<Guest>> GetAll();
    Task<Guest> Get(long GuestId);
    Task <Guest> Create(Guest guest);
    Task <bool> Update(Guest guest);

    Task<bool> Delete(long GuestId);
    
}

public class GuestRepository : BaseRepository,IGuestRepository 
{
    public GuestRepository(IConfiguration configuration) : base(configuration)
    {

    }

    public async Task<Guest> Create(Guest guest)
    {
        var query = @$"INSERT INTO {TableNames.Guest} (name,mobile,email,date_of_birth,address,gender) VALUES(@Name,@Mobile,@Email,@DateOfBirth,@Address,@Gender)RETURNING *";

        using(var con = NewConnection){
            return await con.QuerySingleAsync<Guest>(query,guest);
        }
    }

    public async Task<bool> Delete(long GuestId)
    {
        var query = @$"DELETE FROM {TableNames.Guest} WHERE guest_id = @GuestId ";

        using(var con = NewConnection){
            var rowCount = await con.ExecuteAsync(query, new{
                GuestId=GuestId
            });

            return rowCount == 1;
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

    public async Task<Guest> Get(long Id)
    {
        var query = @$" SELECT * FROM {TableNames.Guest} WHERE guest_id = @Id";
    using(var con = NewConnection)
    {
            return await con.QuerySingleOrDefaultAsync<Guest>(query, new{
                Id=Id
            });  
    }
        
    }

    public async Task<bool> Update(Guest guest)
    {
        var query = @$"UPDATE {TableNames.Guest} SET name=@Name,mobile=@Mobile,email=@Email,date_of_birth=@DateOfBirth,address=@Address,gender=@Gender WHERE guest_id = @GuestID";
     

        using(var con = NewConnection){
            var res =   await con.ExecuteAsync(query,new{
            Name = guest.Name,
            Mobile = guest.Mobile,
            Email = guest.Email,
            DateOfBirth = guest.DateOfBirth,
            Address = guest.Address,
            Gender = guest.Gender,
            GuestID = guest.GuestID
            });
            return res==1;
        }
    }

    
}

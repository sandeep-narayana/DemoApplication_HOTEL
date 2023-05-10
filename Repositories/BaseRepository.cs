using DemoApplication_HOTEL.Settings;
using Npgsql;

namespace DemoApplication_HOTEL.Repositories;


public class BaseRepository
{


private readonly IConfiguration _configuration;

    // constructor
    public BaseRepository(IConfiguration configuration)
    {
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        _configuration = configuration;
    }

    public NpgsqlConnection NewConnection => new NpgsqlConnection(_configuration
    .GetSection(nameof(PostgresSettings)).Get<PostgresSettings>().ConnectionString);
}
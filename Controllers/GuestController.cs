using DemoApplication_HOTEL.DTOs;
using DemoApplication_HOTEL.Models;
using DemoApplication_HOTEL.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace DemoApplication_HOTEL.Controllers;


[ApiController]
[Route("api/guest")]
public class GuestController : ControllerBase
{

    private readonly ILogger<GuestController > _logger;

    private readonly IGuestRepository _guestRepository;

    public GuestController(ILogger<GuestController> logger,IGuestRepository guestRepository 
    )
    {
        _logger = logger;
        _guestRepository = guestRepository;
    }

    [HttpPost]
    public async Task<ActionResult> CreateHandler([FromBody] CreateGuestDTO createGuestDTO)
    {
        var createGuest = new Guest{
            name = createGuestDTO.name,
            Mobile=createGuestDTO.Mobile,
            Email = createGuestDTO.Email,
            DateOfBirth = createGuestDTO.DateOfBirth,
            Address = createGuestDTO.Address,
            Gender = Enum.Parse<Gender>(createGuestDTO.Gender)
        } ;


        var newGuest = await _guestRepository.Create(createGuest);
        return Ok(newGuest);
    }

    [HttpGet]
    public async Task<ActionResult> getAllHandler()
    {
        var guests = await this._guestRepository.GetAll();
        return Ok(guests);
    }


}

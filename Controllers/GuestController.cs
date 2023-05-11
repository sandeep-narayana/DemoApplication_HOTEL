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

    private readonly IScheduleRepository _scheduleRepository;

    public GuestController(ILogger<GuestController> logger,IGuestRepository guestRepository,IScheduleRepository scheduleRepository
    )
    {
        _logger = logger;
        _guestRepository = guestRepository;
        _scheduleRepository=scheduleRepository;
    }


    [HttpGet]
    public async Task<ActionResult> getAllHandler()
    {
        var guests = await this._guestRepository.GetAll();
        return Ok(guests.Select(x=>x.asGuestDto));
    }


    [HttpPost]
    public async Task<ActionResult> CreateHandler([FromBody] GuestDto createGuestDTO)
    {
        var createGuest = new Guest{
            Name = createGuestDTO.Name,
            Mobile=createGuestDTO.Mobile,
            Email = createGuestDTO.Email,
            DateOfBirth = createGuestDTO.DateOfBirth,
            Address = createGuestDTO.Address,
            Gender = Enum.Parse<Gender>(createGuestDTO.Gender)
        } ;


        var newGuest = await _guestRepository.Create(createGuest);
        return Ok(newGuest);
    }

    
    [HttpDelete("{id}")]
    public async Task<ActionResult> delete([FromRoute] long id)
    {
        var res = await this._guestRepository.Delete(id);
        return Ok(res);
    }

    [HttpGet("{GuestId}")]
    public async Task<ActionResult> getHandler([FromRoute]long GuestId)
    {
        var res = await this._guestRepository.Get(GuestId);
        if(res==null){
            return NotFound();
        }
        var dto = res.asGuestDto;
        dto.ScheduleDto = (await this._scheduleRepository.GetById(GuestId)).Select(x=>x.asScheduleDto).ToList();


        return Ok(res.asGuestDto);
    }

    [HttpPut]
    public async Task<ActionResult> update([FromBody]Guest guest)
    {
        var existingGuest = this._guestRepository.Get(guest.GuestID);
        if(existingGuest==null){
            return NotFound();
        }

        var res = await this._guestRepository.Update(guest);
        return Ok(res);

    }


}

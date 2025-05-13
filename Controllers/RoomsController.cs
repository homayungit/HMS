using HMS.Application.Features.Rooms.Queries.GetRoomList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoomsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<RoomListVm>>> GetRooms([FromQuery] GetRoomListQuery query)
        {
            var rooms = await _mediator.Send(query);
            return Ok(rooms);
        }

        //[HttpPost]
        //public async Task<ActionResult<int>> CreateRoom([FromBody] CreateRoomCommand command)
        //{
        //    var result = await _mediator.Send(command);
        //    return Ok(result);
        //}

        //[HttpPut("{id}")]
        //public async Task<ActionResult> UpdateRoom(int id, [FromBody] UpdateRoomCommand command)
        //{
        //    if (id != command.Id)
        //    {
        //        return BadRequest();
        //    }

        //    await _mediator.Send(command);
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult> DeleteRoom(int id)
        //{
        //    await _mediator.Send(new DeleteRoomCommand { Id = id });
        //    return NoContent();
        //}
    }
}
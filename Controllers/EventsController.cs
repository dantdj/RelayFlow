using Microsoft.AspNetCore.Mvc;

namespace RelayFlow.Controllers;

[ApiController]
[Route("events")]
[ProducesResponseType<ProblemDetails>(StatusCodes.Status501NotImplemented)]
public class EventsController : ControllerBase
{
    [HttpPost]
    public IActionResult Create()
    {
        return Problem(statusCode: StatusCodes.Status501NotImplemented,
            detail: "Event creation has not been implemented.");
    }

    [HttpGet("{id}/deliveries")]
    public IActionResult GetDeliveries([FromRoute] string id)
    {
        return Problem(statusCode: StatusCodes.Status501NotImplemented,
            detail: "Event delivery listing has not been implemented.");
    }
}

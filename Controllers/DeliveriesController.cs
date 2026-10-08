using Microsoft.AspNetCore.Mvc;

namespace RelayFlow.Controllers;

[ApiController]
[Route("deliveries")]
[ProducesResponseType<ProblemDetails>(StatusCodes.Status501NotImplemented)]
public class DeliveriesController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult Get([FromRoute] string id)
    {
        return Problem(statusCode: StatusCodes.Status501NotImplemented,
            detail: "Delivery retrieval has not been implemented.");
    }

    [HttpPost("{id}/replay")]
    public IActionResult Replay([FromRoute] string id)
    {
        return Problem(statusCode: StatusCodes.Status501NotImplemented,
            detail: "Delivery replay has not been implemented.");
    }
}

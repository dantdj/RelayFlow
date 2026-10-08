using Microsoft.AspNetCore.Mvc;

namespace RelayFlow.Controllers;

[ApiController]
[Route("subscriptions")]
[ProducesResponseType<ProblemDetails>(StatusCodes.Status501NotImplemented)]
public class SubscriptionsController : ControllerBase
{
    [HttpPost]
    public IActionResult Create()
    {
        return Problem(statusCode: StatusCodes.Status501NotImplemented,
            detail: "Subscription creation has not been implemented.");
    }

    [HttpGet]
    public IActionResult List()
    {
        return Problem(statusCode: StatusCodes.Status501NotImplemented,
            detail: "Subscription listing has not been implemented.");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] string id)
    {
        return Problem(statusCode: StatusCodes.Status501NotImplemented,
            detail: "Subscription deletion has not been implemented.");
    }
}

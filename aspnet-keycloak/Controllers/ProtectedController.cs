using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_keycloak.Controllers;

[ApiController]
[Route("protected")]
public class ProtectedController : ControllerBase
{
    [HttpPost]
    [Authorize(Roles = "Create")]
    public IActionResult Create()
    {
        return Ok("successfully created");
    }

    [HttpDelete]
    [Authorize(Roles = "Delete")]
    public IActionResult Delete()
    {
        return Ok("successfully deleted");
    }
}
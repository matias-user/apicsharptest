
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class UserController : ControllerBase{

    [HttpPost]
    [Route("api/login")]
    public IActionResult Login(){

        UserService userService = new UserService();
       
        return Ok( userService.Login());

    }
}
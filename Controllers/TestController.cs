using Microsoft.AspNetCore.Mvc;

namespace test_dotnet.Controllers;

[ApiController]
[Route("/test")]
public class TestController : ControllerBase {

    [HttpGet]
    public string getHello() {
        return "Hello world";
    }
}
using Microsoft.AspNetCore.Mvc;
using Demo.Handler;
namespace Demo.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class HelloController : ControllerBase
    {
        [HttpGet(Name = "/")]
		public object Get()
		{
			var responseObject = var responseObject = new
			{
				Status = "Hello, world 12345"
			};
			return responseObject;
		}
	}
}
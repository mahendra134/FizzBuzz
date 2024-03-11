using FizzBuzz.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpGet("{start}/{end}")]
        public IActionResult GetFizzBuzz(int start, int end)
        {

            var result = _fizzBuzzService.GenerateFizzBuzz(start, end);
            return Ok(result);
        }
    }
}

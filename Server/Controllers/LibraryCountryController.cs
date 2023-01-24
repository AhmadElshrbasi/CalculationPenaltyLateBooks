using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleTouchTask.Server.Services;

namespace SimpleTouchTask.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryCountryController : ControllerBase
    {
        private readonly ILibraryCountryService _libraryCountryService;
        public LibraryCountryController(ILibraryCountryService libraryCountryService)
        {
            _libraryCountryService = libraryCountryService;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllLibraryCountries()
        {
            var result = await _libraryCountryService.GatAllLibraryCountriesAsync();
            if (!result.Successed)
            {
                ModelState.AddModelError("", result.Message.ToString());
                return BadRequest(ModelState);
            }
            return Ok(result.Message);
        }
    }
}

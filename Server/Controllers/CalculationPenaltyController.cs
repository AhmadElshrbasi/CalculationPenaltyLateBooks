using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleTouchTask.Server.Services;
using SimpleTouchTask.Shared.Dtos;

namespace SimpleTouchTask.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationPenaltyController : ControllerBase
    {
        private readonly ICalculationPenaltyService _calculationPenaltyService;
        public CalculationPenaltyController(ICalculationPenaltyService calculationPenaltyService)
        {
            _calculationPenaltyService = calculationPenaltyService;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CalculationPenalty([FromBody] CalculatePenaltyRequestDto requestDto)
        {
            var result = await  _calculationPenaltyService.CalculatePenaltyAsync(requestDto);
            if (!result.Successed)
            {
                ModelState.AddModelError("", result.Message.ToString());
                return BadRequest(ModelState);
            }
            return Ok(result.Message);
        }
    }
}

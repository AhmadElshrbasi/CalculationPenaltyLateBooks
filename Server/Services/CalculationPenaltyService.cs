using Microsoft.EntityFrameworkCore;
using SimpleTouchTask.Shared;
using SimpleTouchTask.Shared.Dtos;

namespace SimpleTouchTask.Server.Services
{
    public interface ICalculationPenaltyService
    {
        Task<ResultQuery> CalculatePenaltyAsync(CalculatePenaltyRequestDto requestDto);
    }
    public class CalculationPenaltyService : ICalculationPenaltyService
    {
        private readonly SimpleTouchContext _context;
        public CalculationPenaltyService(SimpleTouchContext context)
        {
            _context = context;
        }
        public async Task<ResultQuery> CalculatePenaltyAsync(CalculatePenaltyRequestDto requestDto)
        {
            try
            {
                var penaltyDays= GeneralService.GetDaysBetweenTwoDates(requestDto.EndDate,requestDto.StartDate);
                var country = await _context.libraryCountries.FirstOrDefaultAsync(w => w.Id == requestDto.CountryId); 
                var penaltyValue = GetPenaltyValue(penaltyDays,country.PenaltyValueOneDay);

                return new ResultQuery() { Successed = true, Message = new CalculatePenaltyResponseDto() { penaltyValue = penaltyValue } };
            }
            catch (Exception)
            {
                return new ResultQuery() { Successed = false, Message = "حدث خطأ فى الخادم" };
            }

        }

        private static float GetPenaltyValue(int penaltyDays,float penaltyValueOneDay) => penaltyDays * penaltyValueOneDay;
        
    }
}

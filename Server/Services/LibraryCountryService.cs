using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SimpleTouchTask.Shared;
using SimpleTouchTask.Shared.Dtos;

namespace SimpleTouchTask.Server.Services
{
    public interface ILibraryCountryService
    {
        Task<ResultQuery> GatAllLibraryCountriesAsync();
    }
    public class LibraryCountryService : ILibraryCountryService
    {
        private readonly SimpleTouchContext _context;
        private readonly IMapper _mapper;
        public LibraryCountryService(SimpleTouchContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ResultQuery> GatAllLibraryCountriesAsync()
        {
            try
            {
                var data = await _context.libraryCountries.ToListAsync();
                var dataDto = _mapper.Map<ICollection<LibraryCountryResponseDto>>(data);
                return new ResultQuery() { Successed = true, Message = dataDto};
            }
            catch (Exception ex)
            {
                return new ResultQuery() { Successed = false, Message = "حدث خطأ فى الخادم" };
            }
        }
    }
}

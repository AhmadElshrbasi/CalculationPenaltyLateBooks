using SimpleTouchTask.Shared.Dtos;

namespace SimpleTouchTask.Server.Services
{
    public static class GeneralService
    {
        public static int GetDaysBetweenTwoDates(DateTime endDate, DateTime startDate) => endDate.Subtract(startDate).Days;

    }
}

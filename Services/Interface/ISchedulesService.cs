using SpeedyAir.Models;

namespace SpeedyAir.Services.Interface
{
    internal interface ISchedulesService
    {
        IEnumerable<FlightModel> GetSchedules();
    }
}

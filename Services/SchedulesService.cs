using SpeedyAir.DataSource.Interface;
using SpeedyAir.Models;
using SpeedyAir.Services.Interface;

namespace SpeedyAir.Services
{
    internal class SchedulesService : ISchedulesService
    {
        private readonly IDataSource _dataSource;

        public SchedulesService(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public IEnumerable<FlightModel> GetSchedules()
        {
            return _dataSource.GetSchedules().Values;
        }
    }
}
 
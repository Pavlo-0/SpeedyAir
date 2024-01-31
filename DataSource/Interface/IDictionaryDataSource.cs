using SpeedyAir.Models;

namespace SpeedyAir.DataSource.Interface
{
    internal interface IDictionaryDataSource
    {
        IEnumerable<FlightModel> GetSchedules();

        IEnumerable<PortModel> GetPorts();

        IEnumerable<PlaneModel> GetPlanes();
    }
}
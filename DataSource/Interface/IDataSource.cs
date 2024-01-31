using SpeedyAir.Models;

namespace SpeedyAir.DataSource.Interface
{
    internal interface IDataSource
    {
        IDictionary<int, FlightModel> GetSchedules();

        IDictionary<string, PortModel> GetPorts();

        IDictionary<int, PlaneModel> GetPlanes();

        IEnumerable<OrderModel> GetOrders();
    }
}
 
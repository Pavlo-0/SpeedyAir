using SpeedyAir.Models;

namespace SpeedyAir.Services.Interface
{
    internal interface IFlightOrderService
    {
        IEnumerable<FlightOrderModel> BatchOrders();
    }
}

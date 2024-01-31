using SpeedyAir.DataSource.Interface;
using SpeedyAir.Models;
using SpeedyAir.Services.Interface;

namespace SpeedyAir.Services
{
    internal class FlightOrderService : IFlightOrderService
    {
        private readonly IDataSource _dataSource;

        public FlightOrderService(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public IEnumerable<FlightOrderModel> BatchOrders()
        {
            var result = new List<FlightOrderModel>();

            var orders = _dataSource.GetOrders();
            var planeDictionary = _dataSource.GetPlanes();
            var flightsList = _dataSource.GetSchedules().Values;

            foreach (var orderGrouped in orders.GroupBy(order => order.PortArrivalKey))
            { 
                var skip = 0;

                //Select flights only for this orders group
                var flightsFiltered = flightsList
                    .Where(flight => flight.PortArriverKey.ToUpper() == orderGrouped.Key.ToUpper())
                    .OrderBy(flights => flights.Day);

                //Batch order per flight until has capacity for flights
                foreach (var flight in flightsFiltered)
                {
                    var capacity = planeDictionary[flight.PlaneKey].Capacity;

                    result.AddRange(orderGrouped
                        .Skip(skip)
                        .Take(capacity)
                        .Select(order => new FlightOrderModel(order.Key, flight.Key, flight.PortDepartureKey, flight.PortArriverKey, flight.Day)));
                    skip += capacity;
                }
                //That didn't fit on the plane or no plane at all for that destination
                result.AddRange(orderGrouped.Skip(skip).Select(order => new FlightOrderModel(order.Key, null, null, null, null)));
            }

            return result;
        }

    }
}

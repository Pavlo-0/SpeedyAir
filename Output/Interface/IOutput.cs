using SpeedyAir.Models;

namespace SpeedyAir.Output.Interface
{
    internal interface IOutput
    {
        void OutputSchedule(IEnumerable<FlightModel> flightModels);

        void OutputFlightOrders(IEnumerable<FlightOrderModel> flightOrderModels);
    }
}
 
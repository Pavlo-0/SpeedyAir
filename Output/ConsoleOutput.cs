using SpeedyAir.Models;
using SpeedyAir.Output.Interface;

namespace SpeedyAir.Output
{
    internal class ConsoleOutput : IOutput
    {
        public void OutputFlightOrders(IEnumerable<FlightOrderModel> flightOrderModels)
        {
            foreach (var order in flightOrderModels)
            {
                if (order.FlightKey is not null)
                {
                    Console.WriteLine($"order: {order.OrderKey}, flightNumber: {order.FlightKey}, departure: {order.DeparturePortKey}, arrival: {order.ArrivalPortKey}, day: {order.Day}");
                }
                else
                {
                    Console.WriteLine($"order: {order.OrderKey}, flightNumber: not scheduled");
                }
            }
        }

        public void OutputSchedule(IEnumerable<FlightModel> flightModels)
        {
            foreach (var flight in flightModels)
            {
                Console.WriteLine($"Flight: {flight.Key}, departure: {flight.PortDepartureKey}, arrival: {flight.PortArriverKey}, day: {flight.Day}");
            }
        }
    }
}

namespace SpeedyAir.Models
{
    internal record FlightOrderModel(string OrderKey, int? FlightKey, string? DeparturePortKey, string? ArrivalPortKey, int? Day);
}
 
namespace SpeedyAir.Models
{
    internal record FlightModel (int Key, int Day, int PlaneKey, IOrderedEnumerable<(int Order, string Key)> PortKeys)
    {
        public string PortDepartureKey => PortKeys.First().Key;
        public string PortArriverKey => PortKeys.Last().Key;
    }
}
 
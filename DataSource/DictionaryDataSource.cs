using SpeedyAir.DataSource.Interface;
using SpeedyAir.Models;

namespace SpeedyAir.DataSource
{
    internal class DictionaryDataSource : IDictionaryDataSource
    {
        public IEnumerable<PlaneModel> GetPlanes()
        {
            yield return new PlaneModel(1);
            yield return new PlaneModel(2);
            yield return new PlaneModel(3);
        }

        public IEnumerable<PortModel> GetPorts()
        {
             
            yield return new PortModel("YUL");
            yield return new PortModel("YYZ");
            yield return new PortModel("YYC");
            yield return new PortModel("YVR");
        }

        public IEnumerable<FlightModel> GetSchedules()
        {
            yield return new FlightModel(1, 1, 1, new List<(int order, string key)> { (1, "YUL"), (2, "YYZ") }.OrderBy(port => port.order));
            yield return new FlightModel(2, 1, 2, new List<(int order, string key)> { (1, "YUL"), (2, "YYC") }.OrderBy(port => port.order));
            yield return new FlightModel(3, 1, 3, new List<(int order, string key)> { (1, "YUL"), (2, "YVR") }.OrderBy(port => port.order));

            yield return new FlightModel(4, 2, 1, new List<(int order, string key)> { (1, "YUL"), (2, "YYZ") }.OrderBy(port => port.order));
            yield return new FlightModel(5, 2, 2, new List<(int order, string key)> { (1, "YUL"), (2, "YYC") }.OrderBy(port => port.order));
            yield return new FlightModel(6, 2, 3, new List<(int order, string key)> { (1, "YUL"), (2, "YVR") }.OrderBy(port => port.order));
        }
    }
}
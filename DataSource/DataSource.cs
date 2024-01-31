using SpeedyAir.DataSource.Interface;
using SpeedyAir.Models;

namespace SpeedyAir.DataSource
{
    internal class DataSource : IDataSource
    {
        private readonly IDictionaryDataSource _dictionaryDataSource;
        private readonly ITransactionDataSource _transactionDataSource;

        public DataSource(IDictionaryDataSource dictionaryDataSource, ITransactionDataSource transactionDataSource)
        {
            _dictionaryDataSource = dictionaryDataSource;
            _transactionDataSource = transactionDataSource;
        }
         
        public IDictionary<int, FlightModel> GetSchedules()
        {
            return _dictionaryDataSource.GetSchedules().ToDictionary(flight => flight.Key, flight => flight);
        }

        public IDictionary<string, PortModel> GetPorts()
        {
            return _dictionaryDataSource.GetPorts().ToDictionary(port => port.Key, port => port);
        }

        public IDictionary<int, PlaneModel> GetPlanes()
        {
            return _dictionaryDataSource.GetPlanes().ToDictionary(plane => plane.Key, plane => plane);
        }

        public IEnumerable<OrderModel> GetOrders()
        {
            return _transactionDataSource.GetOrders();
        }
    }
}

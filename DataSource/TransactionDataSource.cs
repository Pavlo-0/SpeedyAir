using SpeedyAir.DataSource.Interface;
using SpeedyAir.Models;
using System.Text.Json;

namespace SpeedyAir.DataSource
{
    internal class TransactionDataSource : ITransactionDataSource
    {
        private record OrderData(string destination);

        public IEnumerable<OrderModel> GetOrders()
        {
            try
            { 
                string filePath = "./Input/coding-assigment-orders.json";
                string jsonData = File.ReadAllText(filePath);
                var orders = JsonSerializer.Deserialize<Dictionary<string, OrderData>>(jsonData) 
                    ?? throw new ArgumentNullException("No orders in order json file");
                return orders.Select((order, index) => new OrderModel(order.Key, order.Value.destination, index));
            }
            catch
            {
                //Log error and do what evere need
                throw;
            }
        }
    }
}
